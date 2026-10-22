using UnityEngine;

public class Pusher : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _force;

    private void OnEnable()
    {
        _inputReader.PushButtonPressed += Push;
    }

    private void OnDisable()
    {
        _inputReader.PushButtonPressed -= Push;
    }

    private void Push()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.transform.TryGetComponent(out Rigidbody rigidbody) && Input.GetKey(KeyCode.Mouse0))
        {
            rigidbody.AddForce(_direction, ForceMode.Impulse);
        }
    }
}
