using UnityEngine;
using Random = UnityEngine.Random;

public class Game : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<Bomb>().BombExplosionEvent += OnBombExplosion;
    }

    private void FixedUpdate()
    {
        if (Random.Range(1, 100) <= 95) return;
        Debug.Log("Describe!");
        FindObjectOfType<Bomb>().BombExplosionEvent -= OnBombExplosion;
    }

    private static void OnBombExplosion(Bomb player)
    {
        Debug.LogError("BOOM");
    }
    
    private void OnDestroy()
    {
        FindObjectOfType<Bomb>().BombExplosionEvent -= OnBombExplosion;
    }
}
