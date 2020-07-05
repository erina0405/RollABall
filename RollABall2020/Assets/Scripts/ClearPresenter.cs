using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearPresenter : MonoBehaviour {

    [SerializeField] private Text m_clearText = null;

    [SerializeField] private PickUpCountPresenter PickUpCountPresenter = null;

	private void Start ()
    {
        //最初の文字は消しておく
        m_clearText.text = string.Empty;
	}
	

	void Update ()
    {
		if (PickUpCountPresenter.GetPickUpCount.Equals(12))
        {
            m_clearText.text = "クリアー";
        }
	}
}
