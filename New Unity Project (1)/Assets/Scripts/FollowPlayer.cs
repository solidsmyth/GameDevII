using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (player.transform.parent != null)
        {
            float interpolation = speed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x+8, interpolation);

            this.transform.position = position;
        }
        else
        {
            float interpolation = speed * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x, interpolation);

            this.transform.position = position;
        }
    }
}
