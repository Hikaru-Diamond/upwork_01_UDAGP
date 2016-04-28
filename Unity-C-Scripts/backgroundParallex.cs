using UnityEngine;
using System.Collections;

public class backgroundParallex : MonoBehaviour {

    float start, end, distance, current, t, k;
    public Transform begining, finish, player;
    public float resistance = 1f;
    private float y, z;

    void Awake () {
        y = this.transform.localPosition.y;
        z = this.transform.localPosition.z;
        start = this.transform.localPosition.x;
        end = start - 6f;
        distance = Mathf.Abs(begining.position.x - finish.position.x);
        current = Mathf.Abs(begining.position.x - player.position.x);
        t = current / distance;
    }

    void Update () {
        current = Mathf.Abs(begining.position.x - player.position.x);
        t = (current / distance)/resistance;
        k = Mathf.Lerp(start, end, t);
        this.transform.localPosition = new Vector3(k, y, z);
    }
    
}
