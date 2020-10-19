
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameMonitor gameMonitor;
    private void OnTriggerEnter(Collider other)
    {
        gameMonitor.CompleteLevel();
    }
}
