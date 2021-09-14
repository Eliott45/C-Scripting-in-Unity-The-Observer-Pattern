using UnityEngine;

public class Game : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<Bomb>().BombExplosionEvent += OnBombExplosion;
    }

    private static void OnBombExplosion(Bomb player)
    {
        Debug.LogError("BOOM");
    }
}
