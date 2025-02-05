using System.Diagnostics;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Lerp")]
    public Transform target;
    public float lerpSpeed = 1f;
    private Vector3 _pos;

    [Header("Text")]
    public TextMeshPro uiTextPowerUp;
    
    [Header("PlayerC")]
    public float speed = 1f;
    private string tagEnemy = "Enemy";
    private string tagEnd = "EndLine";
    private bool _canRun;
    private bool invencible;
    public GameObject endScreen;
    public GameObject startScreen;
    public float _currentSpeed;
    private Vector3 _startPosition;
    public GameObject coinCollector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    private void Start()
    {
        _startPosition = transform.position;
        ResetSpeed();
    }
    void Update()
    {
        if(!_canRun) return;

        _pos = target.position;
        _pos.y = transform.position.y;
        _pos.z = transform.position.z;

        transform.Translate(transform.forward * _currentSpeed * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, _pos, lerpSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == tagEnemy)
        {
            if(!invencible) EndGame();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == tagEnd)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        _canRun = false;
        endScreen.SetActive(true); 
    }

    public void StartToRun()
    {
        _canRun = true;
        startScreen.SetActive(false);
    }

    #region 
    public void SetPowerUpText(string s)
    {
        uiTextPowerUp.text = s;
    }

    public void PowerUpSpeedUp(float f)
    {
        _currentSpeed = f;
    }

    public void ResetSpeed()
    {
        _currentSpeed = speed;
    }

    public void SetInvencible(bool b)
    {
        invencible = b;
    }

    public void ChangeHeight(float amount, float duration, float animationDuration, Ease ease)
    {
        var p = transform.position;
        p.y = _startPosition.y + amount;
        transform.position = p;
    }

    public void ResetHeight()
    {
        var p = transform.position;
        p.y = _startPosition.y;
        transform.position = p;
    }

    public void ChangeCoinsCollectorSize(float amount)
    {
        coinCollector.transform.localScale = Vector3.one * amount;
    }
    #endregion
}
