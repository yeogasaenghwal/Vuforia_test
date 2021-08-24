using UnityEngine;
using Vuforia;

public class VirtualButton_2 : MonoBehaviour
{
    //public GameObject gCube;    //이미지 타켓 밑에 빨간큐브
    //public Material mBlue;      //파랑 머테리얼 - 따로 머테리얼 만듬
    //public Material mRed;       //빨강 머테리얼
    public GameObject Lunch;

    void Start()
    {
        //버튼 이벤트 등록
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    //버튼 눌렀을떄
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //버튼 누르면 큐브 머테리얼을 파랑색으로 바꿔준다.
        //gCube.GetComponent<MeshRenderer>().material = mBlue;
        Lunch.SetActive(true);
        Lunch.GetComponent<Light>().enabled = false;


    }

    //버튼 뗏을때
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //버튼 뗴면 큐브 머테리얼을 빨강색으로 바꿔준다.
        //gCube.GetComponent<MeshRenderer>().material = mRed;
        Lunch.SetActive(false);
    }
}