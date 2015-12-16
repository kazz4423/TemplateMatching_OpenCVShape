using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;

namespace TemplateMatchingOpenCVShape
{
    public partial class Form1 : Form
    {

        private Mat srcImg;
        private Mat tmpImg;

        public Form1()
        {
            InitializeComponent();

            //画像ファイルの読み込み
            srcImg = new Mat("../../lena.jpg");
            pictureBoxIpl1.ImageIpl = srcImg.ToIplImage();

            //テンプレート画像の読み込み
            tmpImg = new Mat("../../lena_tmp.jpg");
            pictureBoxIpl2.ImageIpl = tmpImg.ToIplImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchTemplateMethod mtm;
            bool mtmFlag;

            getMatchTmplateMethod(out mtm, out mtmFlag);

            CvMat result = new CvMat(srcImg.Height - tmpImg.Height + 1, srcImg.Width - tmpImg.Width + 1, MatrixType.F32C1); // リザルト
            Cv.MatchTemplate(srcImg.ToCvMat(), tmpImg.ToCvMat(), result, mtm);
            CvPoint minPoint = new CvPoint();
            CvPoint maxPoint = new CvPoint();
            Cv.MinMaxLoc(result, out minPoint, out maxPoint);
            
            IplImage resultImg = srcImg.ToIplImage(); // picturBoxIplには直接Rectを書き込めないのでバッファを挟む
            if (mtmFlag)
            {
                CvRect rect = new CvRect(maxPoint, tmpImg.ToCvMat().GetSize());
                resultImg.DrawRect(rect, new CvScalar(0, 255, 0), 2);
                label3.Text = result[maxPoint.X, maxPoint.Y].ToString(); // 相関係数の取得
            }
            else
            {
                CvRect rect = new CvRect(minPoint, tmpImg.ToCvMat().GetSize());
                resultImg.DrawRect(rect, new CvScalar(0, 255, 0), 2);
                label3.Text = result[minPoint.X, minPoint.Y].ToString(); // 相関係数の取得
            }
            
            pictureBoxIpl1.ImageIpl = resultImg;

            
        }

        public void getMatchTmplateMethod(out MatchTemplateMethod _mtm, out bool flag)
        {
            switch (comboBox1.Text)
            {
                case "CV_TM_SQDIFF":
                    _mtm = MatchTemplateMethod.SqDiff;
                    flag = false;
                    break;
                case "CV_TM_SQDIFF_NORMED":
                    _mtm = MatchTemplateMethod.SqDiffNormed;
                    flag = false;
                    break;
                case "CV_TM_CCORR":
                    _mtm = MatchTemplateMethod.CCorr;
                    flag = true;
                    break;
                case "CV_TM_CCORR_NORMED":
                    _mtm = MatchTemplateMethod.CCorrNormed;
                    flag = true;
                    break;
                case "CV_TM_CCOEFF":
                    _mtm = MatchTemplateMethod.CCoeff;
                    flag = true;
                    break;
                case "CV_TM_CCOEFF_NORMED":
                    _mtm = MatchTemplateMethod.CCoeffNormed;
                    flag = true;
                    break;
                default:
                    _mtm = MatchTemplateMethod.SqDiff;
                    flag = false;
                    break;
            }
        }
    }
}
