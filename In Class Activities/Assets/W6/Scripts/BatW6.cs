using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Transform _playerTransform;
    public GameObject CatPlayer;
    private bool _isChasing = false;


    private void Start()
    {
        CatPlayer = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (CatPlayer && _isChasing != false)
        { 
            transform.position = Vector3.MoveTowards(transform.position, CatPlayer.transform.position, _speed * Time.deltaTime);
        }
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
