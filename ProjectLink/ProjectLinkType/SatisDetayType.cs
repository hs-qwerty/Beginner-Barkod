using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkType
{
    public class SatisDetayType
    {

        public int sad_recno { get; set; }

        public string  sad_satisevrakno { get; set; }
        public string sad_urunkodu{ get; set; }

        public float sad_miktar { get; set; }

        public float sad_fiyat { get; set; }
        public float sad_tutar { get; set; }
        public float sad_kdvorani { get; set; }
        public float sad_kdvtutari { get; set; }
        public float sad_geneltoplam { get; set; }
    }
}
