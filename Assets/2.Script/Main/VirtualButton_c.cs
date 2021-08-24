using UnityEngine;
using Vuforia;

public class VirtualButton_c : MonoBehaviour
{
    //public GameObject gCube;    //이미지 타켓 밑에 빨간큐브
    //public Material mBlue;      //파랑 머테리얼 - 따로 머테리얼 만듬
    //public Material mRed;       //빨강 머테리얼
    public GameObject Stone_1;
    public GameObject Stone_2;
    public GameObject Stone_3;
    public GameObject Stone_4;
    public AudioSource rain;

    void Start()
    {
        //버튼 이벤트 등록
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    //버튼 눌렀을떄
    public void OnButtonPressed(VirtualButtonBehaviour c)
    {
        //버튼 누르면 큐브 머테리얼을 파랑색으로 바꿔준다.
        //gCube.GetComponent<MeshRenderer>().material = mBlue;
        rain.Play();

        Stone_1.SetActive(true);
        Instantiate(Stone_1);

        Stone_2.SetActive(true);
        Instantiate(Stone_2);

        Stone_3.SetActive(true);
        Instantiate(Stone_3);

        Stone_4.SetActive(true);
        Instantiate(Stone_4);
    


    }

    //버튼 뗏을때
    public void OnButtonReleased(VirtualButtonBehaviour c)
    {
        //버튼 뗴면 큐브 머테리얼을 빨강색으로 바꿔준다.
        //gCube.GetComponent<MeshRenderer>().material = mRed;
        //Happy.SetActive(false);
        rain.Stop();
        Stone_1.SetActive(false);
        Stone_2.SetActive(false);
        Stone_3.SetActive(false);
        Stone_4.SetActive(false);
        
        
    }
}