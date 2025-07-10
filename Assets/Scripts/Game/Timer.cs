using UnityEngine;
using TMPro;
using Unity.Mathematics;
public class Timer : MonoBehaviour
{
    private TMP_Text text;
    [SerializeField] private float timeMax;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void Update()
    {
        timeMax -= Time.deltaTime;
        int value = (int)timeMax;
        value = math.clamp(value, 0, 100);
        text.text = value.ToString();
    }
}
