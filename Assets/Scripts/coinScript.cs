using UnityEngine;

public class coinScript : MonoBehaviour
{
private trailScore trailScoreCoin;

     void Start()
    {
        trailScoreCoin = GameObject.Find("scoreManager").GetComponent<trailScore>();
    }
    void Update()
    {
       
        transform.Translate(Vector3.left * 10f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Coin Scored");
            Destroy(gameObject);
            trailScoreCoin.updateCoins(1);
        }
    }
}
