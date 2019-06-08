using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanja
{
    class GameSetting
    {
        #region フィールド

        public List<string> m_Player { get; set; }
        public int card_num { get; set; }
        public string FilePath { get; set; }
        #endregion

        #region　コンストラクタ

        public GameSetting()
        {
            m_Player = new List<string>();
        }

        #endregion

        #region メソッド



        #endregion

    }
}
