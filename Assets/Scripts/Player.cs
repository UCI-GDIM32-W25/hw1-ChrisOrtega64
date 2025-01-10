using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {

    }

    private void Update()
    {
        // If player inputs W or the Up Arrow, the player will move up
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.UpArrow)))
        {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        // If player inputs S or the Down Arrow, the player will move down
        if (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.DownArrow)))
        {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        // If player inputs A or the Left Arrow, the player will move left
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        // If player inputs D or the Right Arrow, the player will move right
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        // If Space is pressed, it will call upon PlantSeed() function
        if (Input.GetKey(KeyCode.Space))
        {
            PlantSeed();
        }

        }

    public void PlantSeed ()
    {
        // Clones Seed Prefab
        for (int i = 0; i < _numSeeds; i++)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        }
    }
}
