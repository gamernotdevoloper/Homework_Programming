using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject canvas;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            canvas.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
