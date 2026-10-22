using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private KeyCode _push = KeyCode.Mouse0;
    [SerializeField] private KeyCode _create = KeyCode.R;

    public event Action PushButtonPressed;

    public event Action CreateButtonPressed;

    private void Update()
    {
        if (Input.GetKeyDown(_push))
        {
            PushButtonPressed?.Invoke();
        }

        if (Input.GetKeyUp(_create))
        {
            CreateButtonPressed?.Invoke();
        }
    }
}
