using UnityEngine;

public class CubeManager : MonoBehaviour
{

    [SerializeField] GameObject _cubePrefab;

    float _lifeTime;

    public void SetRespawnCube(float _respawnTime, float _cubeSpeed, float _cubeDestination)
    {
        _lifeTime += Time.deltaTime;

        if (_lifeTime >= _respawnTime)
        {
            GameObject cube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);
            _lifeTime = 0;

            FindObjectOfType<Cube>().SetParameters(_cubeSpeed, _cubeDestination);
        }
    }
}
