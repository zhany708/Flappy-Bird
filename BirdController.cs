using UnityEngine;



public class BirdController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public float jumpforce = 5f;


    Rigidbody2D rb;
    AudioSource audioSource;
    bool isGameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        audioSource = GetComponent <AudioSource>();  //引用AudioSource组件
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver) return;
        

        if (Input.GetKeyDown(KeyCode.Space))    //每次按空格时 小鸟往上跳
        {
            Jump();
        }

        if (transform.position.y > 5.66 || transform.position.y < -5.68)    //小鸟出界时游戏结束
        {
            GameOver();
        }
    }



    void Jump()
    {
        rb.velocity = Vector2.up * jumpforce;       //小鸟y轴增加
        audioSource.Play();     // 每次跳跃时播放音效
    }

    void OnTriggerEnter2D(Collider2D other)     //触发器
    {
        if (isGameOver) return;

        ScoreManager.score++;
        Debug.Log("Score: " + ScoreManager.score);      //每次获得分数时在Console中提示
    }

    void OnCollisionEnter2D(Collision2D collision)      //碰撞检查
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;
        rb.velocity = Vector2.zero; // 使玩家无法操控小鸟

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);      //激活游戏结束UI（默认状态下处于非激活）
        }
    }

}
