using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform _cat;
    [SerializeField] private float _speed = 2f;

    private bool _isChasing;

    private void Update()
    {
        if (!_isChasing || _cat == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _cat.position, _speed * Time.deltaTime);
    }

    public void StartChasing()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
