using TMPro;
using UnityEngine;

public class Terrain_Casino : MonoBehaviour
{
    [SerializeField]
    GameObject sol;

    [SerializeField]
    TextMeshProUGUI scoreUI;

    [SerializeField]
    GameObject bouton;

    [SerializeField]
    GameObject joueur;

    int score;
    int cd2;
    int cd1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        cd2 = 0;
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                Instantiate(sol, new Vector3(i*10, 0, j*10), Quaternion.identity);
            }
        }
        Instantiate(bouton, new Vector3(10, 0, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = "Or : " + score;
        if (cd2 > 3600)
        {
            if (score < 1000)
            {
                score += 10;
                cd2 = 0;
            }
        }
        else
        {
            cd2 += 1;
        }

        if ( cd1 > 200)
        {
            if (bouton.transform.position.x - joueur.transform.position.x <= 10)
            {
                if (bouton.transform.position.y - joueur.transform.position.y <= 10)
                {
                    cd1 = 0;
                    score += 2;
                }
            }
        }
    }
}
