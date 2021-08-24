using UnityEngine;
using Vuforia;

public class VirtualButton_a : MonoBehaviour
{
    public AudioSource A;
    //public GameObject Happy;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        this.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Happy.SetActive(true);
        A.Play();

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //Happy.SetActive(false);
        A.Stop();


    }


}
