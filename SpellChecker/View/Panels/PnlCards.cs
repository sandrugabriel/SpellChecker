using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using SpellChecker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellChecker.View.Panels
{
    public class PnlCards : BunifuShadowPanel
    {

        Form1 form;
        List<string> sugesti;

        public System.Windows.Forms.PictureBox pct;
        public Bunifu.UI.WinForms.BunifuLabel lblcuv;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn3;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn2;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn1;
        public BunifuButton2 btn;
        public string cuvGresit;
        public PnlCards(Form1 form1,string cuvGresit, List<string> sugesti1) {

            this.form = form1;
            this.sugesti = sugesti1;
            this.cuvGresit = cuvGresit;

            // PnlCard
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BorderRadius = 10;
            this.BorderThickness = 1;
            this.Location = new System.Drawing.Point(12, 12);
            this.MaximumSize = new System.Drawing.Size(358, 121);
            this.MinimumSize = new System.Drawing.Size(358, 61);
            this.Name = "PnlCard";
            this.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.ShadowColor = System.Drawing.Color.Silver;
            this.ShadowDept = 2;
            this.ShadowDepth = 5;
            this.ShadowTopLeftVisible = false;
            this.Size = new System.Drawing.Size(358, 61);
            this.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.Tag = "close";

            this.pct = new System.Windows.Forms.PictureBox();
            this.lblcuv = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();

            this.Controls.Add(this.pct);
            this.Controls.Add(this.lblcuv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn);

            // pct
            this.pct.Image = Image.FromFile(Application.StartupPath + @"/data/img/point.png");
            this.pct.Location = new System.Drawing.Point(18, 26);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(15, 15);
            this.pct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct.TabIndex = 1;
            this.pct.TabStop = false;
             
            // lblcuv
            this.lblcuv.AllowParentOverrides = false;
            this.lblcuv.AutoEllipsis = true;
            this.lblcuv.AutoSize = false;
            this.lblcuv.CursorType = null;
            this.lblcuv.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuv.Location = new System.Drawing.Point(47, 13);
            this.lblcuv.Name = "lblcuv";
            this.lblcuv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblcuv.Size = new System.Drawing.Size(268, 33);
            this.lblcuv.TabIndex = 0;
            this.lblcuv.Text = cuvGresit;
            this.lblcuv.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblcuv.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
             
            // btn3
            this.btn3.AllowAnimations = true;
            this.btn3.AllowMouseEffects = true;
            this.btn3.AllowToggling = false;
            this.btn3.AnimationSpeed = 200;
            this.btn3.AutoGenerateColors = false;
            this.btn3.AutoRoundBorders = false;
            this.btn3.AutoSizeLeftIcon = true;
            this.btn3.AutoSizeRightIcon = true;
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn3.ButtonText = "bunifuButton21";
            this.btn3.ButtonTextMarginLeft = 0;
            this.btn3.ColorContrastOnClick = 45;
            this.btn3.ColorContrastOnHover = 45;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn3.Font = new System.Drawing.Font("Comfortaa Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn3.IconMarginLeft = 11;
            this.btn3.IconPadding = 10;
            this.btn3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn3.IconSize = 25;
            this.btn3.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn3.IdleBorderRadius = 10;
            this.btn3.IdleBorderThickness = 1;
            this.btn3.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn3.IdleIconLeftImage = null;
            this.btn3.IdleIconRightImage = null;
            this.btn3.IndicateFocus = false;
            this.btn3.Location = new System.Drawing.Point(237, 63);
            this.btn3.Name = "btn3";
            this.btn3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn3.OnDisabledState.BorderRadius = 10;
            this.btn3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn3.OnDisabledState.BorderThickness = 1;
            this.btn3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn3.OnDisabledState.IconLeftImage = null;
            this.btn3.OnDisabledState.IconRightImage = null;
            this.btn3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn3.onHoverState.BorderRadius = 10;
            this.btn3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn3.onHoverState.BorderThickness = 1;
            this.btn3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn3.onHoverState.IconLeftImage = null;
            this.btn3.onHoverState.IconRightImage = null;
            this.btn3.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn3.OnIdleState.BorderRadius = 10;
            this.btn3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn3.OnIdleState.BorderThickness = 1;
            this.btn3.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn3.OnIdleState.IconLeftImage = null;
            this.btn3.OnIdleState.IconRightImage = null;
            this.btn3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn3.OnPressedState.BorderRadius = 10;
            this.btn3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn3.OnPressedState.BorderThickness = 1;
            this.btn3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn3.OnPressedState.IconLeftImage = null;
            this.btn3.OnPressedState.IconRightImage = null;
            this.btn3.Size = new System.Drawing.Size(106, 40);
            this.btn3.TabIndex = 4;
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn3.TextMarginLeft = 0;
            this.btn3.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn3.UseDefaultRadiusAndThickness = true;
             
            // btn2
            this.btn2.AllowAnimations = true;
            this.btn2.AllowMouseEffects = true;
            this.btn2.AllowToggling = false;
            this.btn2.AnimationSpeed = 200;
            this.btn2.AutoGenerateColors = false;
            this.btn2.AutoRoundBorders = false;
            this.btn2.AutoSizeLeftIcon = true;
            this.btn2.AutoSizeRightIcon = true;
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn2.ButtonText = "bunifuButton21";
            this.btn2.ButtonTextMarginLeft = 0;
            this.btn2.ColorContrastOnClick = 45;
            this.btn2.ColorContrastOnHover = 45;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn2.Font = new System.Drawing.Font("Comfortaa Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn2.IconMarginLeft = 11;
            this.btn2.IconPadding = 10;
            this.btn2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn2.IconSize = 25;
            this.btn2.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn2.IdleBorderRadius = 10;
            this.btn2.IdleBorderThickness = 1;
            this.btn2.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn2.IdleIconLeftImage = null;
            this.btn2.IdleIconRightImage = null;
            this.btn2.IndicateFocus = false;
            this.btn2.Location = new System.Drawing.Point(125, 63);
            this.btn2.Name = "btn2";
            this.btn2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn2.OnDisabledState.BorderRadius = 10;
            this.btn2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn2.OnDisabledState.BorderThickness = 1;
            this.btn2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn2.OnDisabledState.IconLeftImage = null;
            this.btn2.OnDisabledState.IconRightImage = null;
            this.btn2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn2.onHoverState.BorderRadius = 10;
            this.btn2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn2.onHoverState.BorderThickness = 1;
            this.btn2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn2.onHoverState.IconLeftImage = null;
            this.btn2.onHoverState.IconRightImage = null;
            this.btn2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn2.OnIdleState.BorderRadius = 10;
            this.btn2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn2.OnIdleState.BorderThickness = 1;
            this.btn2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn2.OnIdleState.IconLeftImage = null;
            this.btn2.OnIdleState.IconRightImage = null;
            this.btn2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn2.OnPressedState.BorderRadius = 10;
            this.btn2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn2.OnPressedState.BorderThickness = 1;
            this.btn2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn2.OnPressedState.IconLeftImage = null;
            this.btn2.OnPressedState.IconRightImage = null;
            this.btn2.Size = new System.Drawing.Size(106, 40);
            this.btn2.TabIndex = 5;
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn2.TextMarginLeft = 0;
            this.btn2.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn2.UseDefaultRadiusAndThickness = true;
             
            // btn1
            this.btn1.AllowAnimations = true;
            this.btn1.AllowMouseEffects = true;
            this.btn1.AllowToggling = false;
            this.btn1.AnimationSpeed = 200;
            this.btn1.AutoGenerateColors = false;
            this.btn1.AutoRoundBorders = false;
            this.btn1.AutoSizeLeftIcon = true;
            this.btn1.AutoSizeRightIcon = true;
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn1.ButtonText = "bunifuButton21";
            this.btn1.ButtonTextMarginLeft = 0;
            this.btn1.ColorContrastOnClick = 45;
            this.btn1.ColorContrastOnHover = 45;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn1.Font = new System.Drawing.Font("Comfortaa Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn1.IconMarginLeft = 11;
            this.btn1.IconPadding = 10;
            this.btn1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn1.IconSize = 25;
            this.btn1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn1.IdleBorderRadius = 10;
            this.btn1.IdleBorderThickness = 1;
            this.btn1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn1.IdleIconLeftImage = null;
            this.btn1.IdleIconRightImage = null;
            this.btn1.IndicateFocus = false;
            this.btn1.Location = new System.Drawing.Point(13, 63);
            this.btn1.Name = "btn1";
            this.btn1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn1.OnDisabledState.BorderRadius = 10;
            this.btn1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn1.OnDisabledState.BorderThickness = 1;
            this.btn1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn1.OnDisabledState.IconLeftImage = null;
            this.btn1.OnDisabledState.IconRightImage = null;
            this.btn1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn1.onHoverState.BorderRadius = 10;
            this.btn1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn1.onHoverState.BorderThickness = 1;
            this.btn1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn1.onHoverState.IconLeftImage = null;
            this.btn1.onHoverState.IconRightImage = null;
            this.btn1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn1.OnIdleState.BorderRadius = 10;
            this.btn1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn1.OnIdleState.BorderThickness = 1;
            this.btn1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn1.OnIdleState.IconLeftImage = null;
            this.btn1.OnIdleState.IconRightImage = null;
            this.btn1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn1.OnPressedState.BorderRadius = 10;
            this.btn1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn1.OnPressedState.BorderThickness = 1;
            this.btn1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn1.OnPressedState.IconLeftImage = null;
            this.btn1.OnPressedState.IconRightImage = null;
            this.btn1.Size = new System.Drawing.Size(106, 40);
            this.btn1.TabIndex = 6;
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn1.TextMarginLeft = 0;
            this.btn1.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn1.UseDefaultRadiusAndThickness = true;

            // btn
            // 
            this.btn.AllowAnimations = true;
            this.btn.AllowMouseEffects = true;
            this.btn.AllowToggling = false;
            this.btn.AnimationSpeed = 200;
            this.btn.AutoGenerateColors = false;
            this.btn.AutoRoundBorders = false;
            this.btn.AutoSizeLeftIcon = true;
            this.btn.AutoSizeRightIcon = true;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn.ButtonText = "";
            this.btn.ButtonTextMarginLeft = 0;
            this.btn.ColorContrastOnClick = 45;
            this.btn.ColorContrastOnHover = 45;
            this.btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn.DisabledBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.DisabledFillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.DisabledForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn.IconMarginLeft = 11;
            this.btn.IconPadding = 10;
            this.btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn.IconSize = 25;
            this.btn.IdleBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.IdleBorderRadius = 25;
            this.btn.IdleBorderThickness = 1;
            this.btn.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.IdleIconLeftImage = null;
            this.btn.IdleIconRightImage = null;
            this.btn.IndicateFocus = false;
            this.btn.Location = new System.Drawing.Point(7, 4);
            this.btn.Name = "btn";
            this.btn.OnDisabledState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnDisabledState.BorderRadius = 25;
            this.btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn.OnDisabledState.BorderThickness = 1;
            this.btn.OnDisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnDisabledState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnDisabledState.IconLeftImage = null;
            this.btn.OnDisabledState.IconRightImage = null;
            this.btn.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.onHoverState.BorderRadius = 25;
            this.btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn.onHoverState.BorderThickness = 1;
            this.btn.onHoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn.onHoverState.IconLeftImage = null;
            this.btn.onHoverState.IconRightImage = null;
            this.btn.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnIdleState.BorderRadius = 25;
            this.btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn.OnIdleState.BorderThickness = 1;
            this.btn.OnIdleState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn.OnIdleState.IconLeftImage = null;
            this.btn.OnIdleState.IconRightImage = null;
            this.btn.OnPressedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnPressedState.BorderRadius = 25;
            this.btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn.OnPressedState.BorderThickness = 1;
            this.btn.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn.OnPressedState.IconLeftImage = null;
            this.btn.OnPressedState.IconRightImage = null;
            this.btn.Size = new System.Drawing.Size(345, 54);
            this.btn.TabIndex = 4;
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.TextMarginLeft = 0;
            this.btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn.UseDefaultRadiusAndThickness = true;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;

            btn1.Visible = btn2.Visible = btn3.Visible = false;
            if (sugesti.Count >= 1)
            {
                if (sugesti.Count == 1)
                {
                    btn1.Text = sugesti[0];
                    btn1.Visible = true;
                }


                if (sugesti.Count == 2)
                {

                    btn1.Text = sugesti[0];
                    btn1.Visible = true;
                    btn2.Text = sugesti[1];
                    btn2.Visible = true;

                }

                if (sugesti.Count == 3)
                {

                    btn1.Text = sugesti[0];
                    btn1.Visible = true;
                    btn2.Text = sugesti[1];
                    btn2.Visible = true;
                    btn3.Visible = true;
                    btn3.Text = sugesti[2];

                }
            }
           


        }

        

    }
}
