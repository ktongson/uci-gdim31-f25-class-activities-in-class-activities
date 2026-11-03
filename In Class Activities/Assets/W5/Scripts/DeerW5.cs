using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    [SerializeField] private Transform _target;

    NavMeshAgent myNavMeshAgent;
    private void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (_target != null)
        {
            myNavMeshAgent.SetDestination(_target.position);
        }
    }
    public bool SetTarget(Transform target)
    {
        if (target == null)
        {
            return false;
        }
        _target = target;
        myNavMeshAgent.SetDestination(_target.position);
        return true;
    }
}