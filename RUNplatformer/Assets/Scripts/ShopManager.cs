using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    
    public GameObject[] ButtonBuyPlayers;
    public TextMeshProUGUI[] TextPrice;
    public GameObject[] ButtonBuyMap;
    public TextMeshProUGUI[] TextPriceMap;
    public TextMeshProUGUI TextCoins;
    public int coinsindex;
    public int PricePlayer1;
    public int PricePlayer2;
    public int PricePlayer3;
    public int PricePlayer4;
    public int PricePlayer5;
    public int PricePlayer6;
    public int PriceMap1;
    public int PriceMap2;
    public int PriceMap3;
    public int PriceMap4;
    public int PriceMap5;
    public int PriceMap6;
    private int _block1;
    private int _block2;
    private int _block3;
    private int _block4;
    private int _block5;
    private int _block6;
    private int _blockmap1;
    private int _blockmap2;
    private int _blockmap3;
    private int _blockmap4;
    private int _blockmap5;
    private int _blockmap6;

    private void Update()
    {
        
        ShopPlayers();
        
    }

    public void ShopPlayers()
    {
        _block1 = PlayerPrefs.GetInt("block1");
        _block2 = PlayerPrefs.GetInt("block2");
        _block3 = PlayerPrefs.GetInt("block3");
        _block4 = PlayerPrefs.GetInt("block4");
        _block5 = PlayerPrefs.GetInt("block5");
        _block6 = PlayerPrefs.GetInt("block6");
        _blockmap1 = PlayerPrefs.GetInt("blockmap1");
        _blockmap2 = PlayerPrefs.GetInt("blockmap2");
        _blockmap3 = PlayerPrefs.GetInt("blockmap3");
        coinsindex = PlayerPrefs.GetInt("coinss");
        TextCoins.text = "" + coinsindex;
        TextPrice[0].text = "" + PricePlayer1;
        TextPrice[1].text = "" + PricePlayer2;
        TextPrice[2].text = "" + PricePlayer3;
        TextPrice[3].text = "" + PricePlayer4;
        TextPrice[4].text = "" + PricePlayer5;
        TextPrice[5].text = "" + PricePlayer6;

        TextPriceMap[0].text = "" + PriceMap1;
        TextPriceMap[1].text = "" + PriceMap2;
        TextPriceMap[2].text = "" + PriceMap3;

        if (_block1 == 1)
        {
            ButtonBuyPlayers[0].SetActive(false);

        }
        if (_block2 == 1)
        {
            ButtonBuyPlayers[1].SetActive(false);
        }
        if (_block3 == 1)
        {
            ButtonBuyPlayers[2].SetActive(false);
        }
        if (_block4 == 1)
        {
            ButtonBuyPlayers[3].SetActive(false);
        }
        if (_block5 == 1)
        {
            ButtonBuyPlayers[4].SetActive(false);
        }
        if (_block6 == 1)
        {
            ButtonBuyPlayers[5].SetActive(false);
        }




        if (_blockmap1 == 1)
        {
            ButtonBuyMap[0].SetActive(false);
        }
        if (_blockmap2 == 1)
        {
            ButtonBuyMap[1].SetActive(false);
        }
        if (_blockmap3 == 1)
        {
            ButtonBuyMap[2].SetActive(false);
        }
    }

    public void BuyPlayer1()
    {
        if (coinsindex >= PricePlayer1 )
        {
            coinsindex -= PricePlayer1;
            _block1 = 1;
            PlayerPrefs.SetInt("block1", _block1);
        }
    }
    public void BuyPlayer2()
    {
        if (coinsindex >= PricePlayer2 )
        {
            coinsindex -= PricePlayer2;
            _block2 = 1;
            PlayerPrefs.SetInt("block2", _block2);
        }
    }
    public void BuyPlayer3()
    {
        if (coinsindex >= PricePlayer3)
        {
            coinsindex -= PricePlayer3;
            _block3 = 1;
            PlayerPrefs.SetInt("block3", _block3);
        }
    }
    public void BuyPlayer4()
    {
        if (coinsindex >= PricePlayer4 )
        {
            coinsindex -= PricePlayer4;
            _block4 = 1;
            PlayerPrefs.SetInt("block4", _block4);
        }
    }
    public void BuyPlayer5()
    {
        if (coinsindex >= PricePlayer5 )
        {
            coinsindex -= PricePlayer5;
            _block5 = 1;
            PlayerPrefs.SetInt("block5", _block5);
        }
    }
    public void BuyPlayer6()
    {
        if (coinsindex >= PricePlayer6 )
        {
            coinsindex -= PricePlayer6;
            _block6 = 1;
            PlayerPrefs.SetInt("block6", _block6);
        }
    }




    public void BuyMap1()
    {
        if (coinsindex >= PriceMap1)
        {
            coinsindex -= PriceMap1;
            _blockmap1 = 1;
            PlayerPrefs.SetInt("blockmap1", _blockmap1);
        }
    }
    public void BuyMap2()
    {
        if (coinsindex >= PriceMap2)
        {
            coinsindex -= PriceMap2;
            _blockmap2 = 1;
            PlayerPrefs.SetInt("blockmap2", _blockmap2);
        }
    }
    public void BuyMap3()
    {
        if (coinsindex >= PriceMap3)
        {
            coinsindex -= PriceMap3;
            _blockmap3 = 1;
            PlayerPrefs.SetInt("blockmap3", _blockmap3);
        }
    }
    public void BuyMap4()
    {
        if (coinsindex >= PriceMap4)
        {
            coinsindex -= PriceMap4;
            _blockmap4 = 1;
            PlayerPrefs.SetInt("blockmap4", _blockmap4);
        }
    }
    public void BuyMap5()
    {
        if (coinsindex >= PriceMap5)
        {
            coinsindex -= PriceMap5;
            _blockmap5 = 1;
            PlayerPrefs.SetInt("blockmap5", _blockmap5);
        }
    }
    public void BuyMap6()
    {
        if (coinsindex >= PriceMap6)
        {
            coinsindex -= PriceMap6;
            _blockmap6 = 1;
            PlayerPrefs.SetInt("blockmap6", _blockmap6);
        }
    }

}
