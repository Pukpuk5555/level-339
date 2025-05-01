using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject winTextUI; // ตัวแปรสำหรับ UI ที่จะแสดงผล

    void Start()
    {
        winTextUI.SetActive(false); // ซ่อน UI ตอนเริ่มเกม
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าผู้เล่นชน Trigger หรือไม่
        {
            winTextUI.SetActive(true); // แสดง UI "You Win!"
            Debug.Log("You Win!"); // แสดง Log ใน Console
        }
    }
}
