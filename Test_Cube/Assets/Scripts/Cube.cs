using UnityEngine;

public class Cube : MonoBehaviour
{

    float _speed;
    float _destination;

    public void SetParameters(float _cubeSpeed, float _cubeDestination)
    {
        _speed = _cubeSpeed;
        _destination = _cubeDestination;
    }

    private void Update()
    {
        transform.position += new Vector3(_speed * Time.deltaTime, 0, 0);

        if (_destination <= transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}

