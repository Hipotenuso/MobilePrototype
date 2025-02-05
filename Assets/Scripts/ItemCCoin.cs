using UnityEngine;

public class ItemCCoin : ItemCBase
{
    public PlayerController playerController;
    public Collider colliderr;
    public bool collect = false;
    public float lerp = 5f;
    public float minDistance = 1f;

    private void Start()
    {
        if (playerController == null)
        {
            playerController = GameObject.Find("PlayerContainer").GetComponent<PlayerController>();
        }

        if (colliderr== null)
        {
            colliderr = gameObject.GetComponent<Collider>();
        }
    }

    protected override void OnCollect()
    {
        base.OnCollect();
        colliderr.enabled = false;
        collect = true;
    }

    private void Update()
    {
        if(collect)
        {
            transform.position = Vector3.Lerp(transform.position, playerController.transform.position, lerp * Time.deltaTime);
            if(Vector3.Distance(transform.position, playerController.transform.position) < minDistance)
            {
                //HideItens();
                Destroy(gameObject);
            }
        }
    }
}
