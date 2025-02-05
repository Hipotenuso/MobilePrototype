using System.Transactions;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    [Header("TouchC")]
    public Vector2 pastPosition;
    public float velocity = 1f;
    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //mousePosition AGORA - mousePosition PASSADO
            Move(Input.mousePosition.x - pastPosition.x);
        }
        pastPosition = Input.mousePosition;
    }

    public void Move(float speed)
    {
        transform.position += Vector3.right * Time.deltaTime * speed * velocity;
    }
}
