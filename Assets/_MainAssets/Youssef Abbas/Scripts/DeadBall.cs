using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeadBall : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI playerScoreText;
    [SerializeField] private TMPro.TextMeshProUGUI enemyScoreText;

    private Vector3 ballSpawnPoint = new Vector3(0,0.6f, -0.08f);

    [SerializeField] private int playerScore;
    [SerializeField] private int enemyScore;

    public int PlayerScore { get => playerScore; set => playerScore = value; }
    public int EnemyScore { get => enemyScore; set => enemyScore = value; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerGoal"))
        {
            EnemyScore++;
            enemyScoreText.text = EnemyScore.ToString();
            transform.position = ballSpawnPoint;
        }

        if (collision.gameObject.CompareTag("EnemyGoal"))
        {

            PlayerScore++;
            playerScoreText.text = PlayerScore.ToString();
            transform.position = ballSpawnPoint;
        }
    }
}
