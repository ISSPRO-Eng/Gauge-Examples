using MeterGraphicsExample.Drawables;
using System.Timers;

namespace MeterGraphicsExample;

public partial class MainPage : ContentPage
{
    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Initialization code here
        var graphicsView = MeterDrawableView;
        var meterDrawable = (MeterDrawable)graphicsView.Drawable;
        meterDrawable.HorizontalMode = false;

        meterDrawable.GradiantFill = true;
        meterDrawable.Steps = 10;
        meterDrawable.BaseTickSize = 10;
        meterDrawable.ShowSeries = true;

        var radialView = this.RadialGaugeView;
        var radialDrawable = (RadialGaugeDrawable)radialView.Drawable;
        radialDrawable.MaxValue = 100;
        radialDrawable.GradiantFill = true;
        radialDrawable.Steps = 10;
    }
    public MainPage()
    {
        InitializeComponent();

        //var timer = new System.Timers.Timer(50);
        //timer.Elapsed += new ElapsedEventHandler(DrainMeter);

        // You can get the drawable and set settings in this constructor,
        // to manipulate before it's drawn
        // the first time
        var graphicsView = MeterDrawableView;
        var meterDrawable = (MeterDrawable)graphicsView.Drawable;
        meterDrawable.HorizontalMode = false;

        meterDrawable.GradiantFill = true;
        meterDrawable.Steps = 10; 
        meterDrawable.BaseTickSize = 10;
        meterDrawable.ShowSeries = true;
        //timer.Start();

        var radialView = this.RadialGaugeView;
        var radialDrawable = (RadialGaugeDrawable)radialView.Drawable;
        radialDrawable.MaxValue = 100;
        radialDrawable.GradiantFill = true;
        radialDrawable.Steps = 10; 

    }

    private void DrainMeter(object sender, EventArgs e)
    {
        var graphicsView = MeterDrawableView;
        var meterDrawable = (MeterDrawable)graphicsView.Drawable;
        meterDrawable.HorizontalMode = false;


        if (meterDrawable.FillValue != 0)
        {
            meterDrawable.FillValue -= 1;
            graphicsView.Invalidate();
        }


        var radialView = this.RadialGaugeView;
        var radialDrawable = (RadialGaugeDrawable)radialView.Drawable;

        radialDrawable.GaugeThickness = 2;
        if (radialDrawable.FillValue != 0)
        {
            radialDrawable.FillValue -= 1;
            radialView.Invalidate(); 
        }
    }

    private void UpButton(object sender, EventArgs e)
    {
        var graphicsView = MeterDrawableView;
        var meterDrawable = (MeterDrawable)graphicsView.Drawable;

        meterDrawable.FillValue += 10;

        graphicsView.Invalidate(); 
        
        
        var radialView = this.RadialGaugeView;
        var radialDrawable = (RadialGaugeDrawable)radialView.Drawable;

        radialDrawable.FillValue += 10;
        radialView.Invalidate(); 
    }

    private void DownButton(object sender, EventArgs e)
    {
        var graphicsView = MeterDrawableView;
        var meterDrawable = (MeterDrawable)graphicsView.Drawable;

        meterDrawable.FillValue -= 10;

        graphicsView.Invalidate();


        var radialView = this.RadialGaugeView;
        var radialDrawable = (RadialGaugeDrawable)radialView.Drawable;

        radialDrawable.FillValue -= 10;
        radialView.Invalidate();
    }
}
