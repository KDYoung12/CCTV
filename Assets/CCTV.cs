using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    public GameObject cctv_1;
    public GameObject cctv_2;
    public GameObject cctv_3;
    public GameObject cctv_4;
    public void OnClickCCTVOne()
    {
        cctv_1.SetActive(true);
        cctv_2.SetActive(false);
        cctv_3.SetActive(false);
        cctv_4.SetActive(false);
    }
    public void OnClickCCTVTwo()
    {
        cctv_1.SetActive(false);
        cctv_2.SetActive(true);
        cctv_3.SetActive(false);
        cctv_4.SetActive(false);
    }
    public void OnClickCCTVThree()
    {
        cctv_1.SetActive(false);
        cctv_2.SetActive(false);
        cctv_3.SetActive(true);
        cctv_4.SetActive(false);
    }
    public void OnClickCCTVFour()
    {
        cctv_1.SetActive(false);
        cctv_2.SetActive(false);
        cctv_3.SetActive(false);
        cctv_4.SetActive(true);
    }
}
