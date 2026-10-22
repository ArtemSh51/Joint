using UnityEngine;

public class ProjectileCreator : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Transform _projectile;
    [SerializeField] private Transform _spawner;

    private void OnEnable()
    {
        _inputReader.CreateButtonPressed += CreateProjectile;
    }

    private void OnDisable()
    {
        _inputReader.CreateButtonPressed -= CreateProjectile;
    }

    private void CreateProjectile()
    {
        Instantiate(_projectile, _spawner.position, Quaternion.identity);
    }
}
