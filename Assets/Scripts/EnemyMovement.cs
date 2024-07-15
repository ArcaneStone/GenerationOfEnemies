using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector3 _direction;

    public void SetMovementDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }
}
