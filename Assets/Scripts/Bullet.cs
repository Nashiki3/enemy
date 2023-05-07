using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid; //что наша пуля будет считать твёрдым и что будет пробивать
    [SerializeField] bool enemyBullet;
    public GameObject bulletEffect;
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid); //для нахождение  обьекта
        if(hitInfo.collider != null) //если пуля столкнулась с коллайдером
        {
            if (hitInfo.collider.CompareTag("Enemy")) // и если у него тег енеми
            {
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage); // то мы наносим урон нашему врагу
            }
            if (hitInfo.collider.CompareTag("Player")&& enemyBullet) // и если у него тег енеми
            {
                hitInfo.collider.GetComponent<Player>().ChangeHealth(-damage); // то мы наносим урон нашему врагу
            }
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            Destroy(gameObject); // и уничтожаем нашу пулю
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
