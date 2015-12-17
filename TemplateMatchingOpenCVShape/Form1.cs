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
            srcImg = new Mat("../../jozai/カプセルサンプル7.bmp");
            pictureBoxIpl1.ImageIpl = srcImg.ToIplImage();

            //テンプレート画像の読み込み
            tmpImg = new Mat("../../jozai/カプセルサンプル１_string.bmp");
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
            double max_val, min_val;
            Cv.MinMaxLoc(result, out min_val, out max_val,out minPoint, out maxPoint);
            
            IplImage resultImg = srcImg.ToIplImage(); // pictureBoxIplには直接Rectを書き込めないのでバッファを挟む
            if (mtmFlag)
            {
                CvRect rect = new CvRect(maxPoint, tmpImg.ToCvMat().GetSize());
                resultImg.DrawRect(rect, new CvScalar(255, 255, 255), 2);
                //label3.Text = result[maxPoint.X, maxPoint.Y].ToString(); // 相関係数の取得
                label3.Text = max_val.ToString(); // 相関係数の取得
            }
            else
            {
                CvRect rect = new CvRect(minPoint, tmpImg.ToCvMat().GetSize());
                resultImg.DrawRect(rect, new CvScalar(255, 255, 255), 2);
                //label3.Text = result[minPoint.X, minPoint.Y].ToString(); // 相関係数の取得
                label3.Text = min_val.ToString(); // 相関係数の取得
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

        private void button2_Click(object sender, EventArgs e)
        {
            int d1, d2;
            d1 = 500;
            d2 = 600;
            IplImage dst;
            dst = new IplImage(srcImg.ToIplImage().Size, srcImg.ToIplImage().Depth, 1);

            Cv.Canny(srcImg.ToCvMat(), dst, d1, d2, ApertureSize.Size5);

            pictureBoxIpl1.ImageIpl = dst;
            srcImg = new Mat(dst);

            dst = new IplImage(tmpImg.ToIplImage().Size, tmpImg.ToIplImage().Depth, 1);

            Cv.Canny(tmpImg.ToCvMat(), dst, d1, d2, ApertureSize.Size5);

            pictureBoxIpl2.ImageIpl = dst;
            tmpImg = new Mat(dst);

        }
    }
}
