using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TMP_Text text;
    [SerializeField] private float timeMax;
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    void Update()
    {
        timeMax -= Time.deltaTime;
        int value = (int)timeMax;
        value = math.clamp(value, 0, 100);
        text.text = value.ToString();
    }
}
