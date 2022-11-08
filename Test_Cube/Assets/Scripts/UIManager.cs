using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] TMP_InputField _inRespawnTime;
    [SerializeField] TMP_InputField _inCubeSpeed;
    [SerializeField] TMP_InputField _inDestination;

    float _respawnTime;
    float _cubeSpeed;
    float _cubeDestination;

    public void SetSpawnTime()
    {
        _respawnTime = float.Parse(_inRespawnTime.text);
    }

    public void SetSpeed()
    {
        _cubeSpeed = float.Parse(_inCubeSpeed.text);
    }

    public void SetDestination()
    {
        _cubeDestination = float.Parse(_inDestination.text);
    }

    private void Update()
    {
        if (_respawnTime > 0)
        {
            FindObjectOfType<CubeManager>().SetRespawnCube(_respawnTime, _cubeSpeed, _cubeDestination);
        }
    }
}
