using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using SpellChecker.HashTable;
using SpellChecker.HashTable.interfaces;
using SpellChecker.Properties;
using SpellChecker.View.Mockups;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellChecker.View.Panels
{
    public class PnlHome : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.PictureBox pnlWhite;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlMain2;
        private System.Windows.Forms.Panel pnlDark;
        private Bunifu.UI.WinForms.BunifuPanel pnlMain1;
        private Bunifu.UI.WinForms.BunifuTextBox txtText;
        private System.Windows.Forms.Label lblEnglish;
        private Bunifu.UI.WinForms.BunifuPictureBox pctFlag;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblCountWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblCountCharacter;
        private Bunifu.UI.WinForms.BunifuPanel pnlMistake;
        private System.Windows.Forms.Label lblCountMistake;
        private System.Windows.Forms.Label lblMistake;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnInsert;

        private Bunifu.UI.WinForms.BunifuLoader loader;
        private System.Windows.Forms.Label lblLoder;

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer2;

        private BunifuLabel lblmis;

        IHashTable<int, string> hashTable;
        List<string> cuvGresite;
        List<string> cuvinte;

        List<PnlCards> pnlsMistake;

        public PnlHome(Form1 form1) {
        
            this.form = form1;
            hashTable = new HashTable<int, string>(130);
            cuvGresite = new List<string>();
            cuvinte = new List<string>();
            pnlsMistake = new List<PnlCards>();

            //PnlHome
            this.BackColor = SystemColors.ButtonFace;
            this.Size = new System.Drawing.Size(1430, 714);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PnlHome";
            this.Location = new Point(2, 54);
            this.SizeChanged += new EventHandler(this_SizeChanged);

            this.lblTile = new System.Windows.Forms.Label();
            this.pnlWhite = new System.Windows.Forms.PictureBox();
            this.pnlMain2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lblCountCharacter = new System.Windows.Forms.Label();
            this.lblCountWord = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.pnlDark = new System.Windows.Forms.Panel();
            this.pnlMain1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pctFlag = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.txtText = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlMistake = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblMistake = new System.Windows.Forms.Label();
            this.lblCountMistake = new System.Windows.Forms.Label();
            this.btnInsert = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.lblLoder = new Label();
            this.timer = new System.Windows.Forms.Timer();
            this.lblmis = new BunifuLabel();
            this.timer2 = new System.Windows.Forms.Timer();

            this.Controls.Add(this.pnlMistake);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.pnlDark);
            this.Controls.Add(this.pnlMain2);
            this.Controls.Add(this.pnlWhite);

            // lblTile
            this.lblTile.AutoSize = true;
            this.lblTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(247)))));
            this.lblTile.Location = new System.Drawing.Point(430, 22);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(594, 68);
            this.lblTile.TabIndex = 1;
            this.lblTile.Text = "Write Correct Paraphrase";
            
            // pnlWhite
            this.pnlWhite.BackColor = System.Drawing.Color.White;
            this.pnlWhite.Location = new System.Drawing.Point(-22, 423);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(1481, 322);
            this.pnlWhite.TabIndex = 2;
            this.pnlWhite.TabStop = false;
             
            // pnlMain2
            this.pnlMain2.BackColor = System.Drawing.Color.White;
            this.pnlMain2.BorderColor = System.Drawing.Color.White;
            this.pnlMain2.BorderRadius = 15;
            this.pnlMain2.BorderThickness = 0;
            this.pnlMain2.Controls.Add(this.btnInsert);
            this.pnlMain2.Controls.Add(this.lblCountCharacter);
            this.pnlMain2.Controls.Add(this.lblCountMistake);
            this.pnlMain2.Controls.Add(this.lblCountWord);
            this.pnlMain2.Controls.Add(this.lblMistake);
            this.pnlMain2.Controls.Add(this.lblWord);
            this.pnlMain2.Controls.Add(this.lblCharacter);
            this.pnlMain2.Controls.Add(this.lblLoder);
            this.pnlMain2.Controls.Add(this.loader);
            this.pnlMain2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlMain2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.ForwardDiagonal;
            this.pnlMain2.Location = new System.Drawing.Point(76, 192);
            this.pnlMain2.Name = "pnlMain2";
            this.pnlMain2.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain2.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlMain2.ShadowColor = System.Drawing.Color.DimGray;
            this.pnlMain2.ShadowDept = 2;
            this.pnlMain2.ShadowDepth = 10;
            this.pnlMain2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlMain2.ShadowTopLeftVisible = false;
            this.pnlMain2.Size = new System.Drawing.Size(1304, 485);
            this.pnlMain2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlMain2.TabIndex = 3;
             
            // lblCountCharacter
            this.lblCountCharacter.AutoSize = true;
            this.lblCountCharacter.BackColor = System.Drawing.Color.White;
            this.lblCountCharacter.Font = new System.Drawing.Font("Comfortaa Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(140)))));
            this.lblCountCharacter.Location = new System.Drawing.Point(130, 441);
            this.lblCountCharacter.Name = "lblCountCharacter";
            this.lblCountCharacter.Size = new System.Drawing.Size(18, 26);
            this.lblCountCharacter.TabIndex = 0;
            this.lblCountCharacter.Text = "1";
             
            // lblCountWord
            this.lblCountWord.AutoSize = true;
            this.lblCountWord.BackColor = System.Drawing.Color.White;
            this.lblCountWord.Font = new System.Drawing.Font("Comfortaa Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(140)))));
            this.lblCountWord.Location = new System.Drawing.Point(235, 441);
            this.lblCountWord.Name = "lblCountWord";
            this.lblCountWord.Size = new System.Drawing.Size(18, 26);
            this.lblCountWord.TabIndex = 0;
            this.lblCountWord.Text = "1";
             
            // lblWord
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.Font = new System.Drawing.Font("Comfortaa Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.lblWord.Location = new System.Drawing.Point(173, 439);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(56, 28);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word";
             
            // lblCharacter
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.BackColor = System.Drawing.Color.White;
            this.lblCharacter.Font = new System.Drawing.Font("Comfortaa Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.lblCharacter.Location = new System.Drawing.Point(32, 439);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(101, 28);
            this.lblCharacter.TabIndex = 0;
            this.lblCharacter.Text = "Character";
             
            // pnlDark
            this.pnlDark.Controls.Add(this.pnlMain1);
            this.pnlDark.Controls.Add(this.lblTile);
            this.pnlDark.Location = new System.Drawing.Point(-8, -10);
            this.pnlDark.Name = "pnlDark";
            this.pnlDark.Size = new System.Drawing.Size(1455, 436);
            this.pnlDark.TabIndex = 4;
            this.pnlDark.BackColor = Color.FromArgb(4, 26, 55);
             
            // pnlMain1
            this.pnlMain1.BackgroundColor = System.Drawing.Color.White;
            this.pnlMain1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain1.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain1.BorderRadius = 20;
            this.pnlMain1.BorderThickness = 0;
            this.pnlMain1.Controls.Add(this.pctFlag);
            this.pnlMain1.Controls.Add(this.lblEnglish);
            this.pnlMain1.Location = new System.Drawing.Point(93, 204);
            this.pnlMain1.Name = "pnlMain1";
            this.pnlMain1.ShowBorders = true;
            this.pnlMain1.Size = new System.Drawing.Size(1286, 274);
            this.pnlMain1.TabIndex = 2;
             
            // pctFlag
            this.pctFlag.AllowFocused = false;
            this.pctFlag.BackColor = System.Drawing.Color.White;
            this.pctFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctFlag.BorderRadius = 14;
            this.pctFlag.Image = Image.FromFile(Application.StartupPath + @"/data/img/flag.png");
            this.pctFlag.IsCircle = false;
            this.pctFlag.Location = new System.Drawing.Point(31, 13);
            this.pctFlag.Name = "pctFlag";
            this.pctFlag.Size = new System.Drawing.Size(28, 28);
            this.pctFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctFlag.TabIndex = 1;
            this.pctFlag.TabStop = false;
            this.pctFlag.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
             
            // lblEnglish
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.BackColor = System.Drawing.Color.White;
            this.lblEnglish.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(58, 15);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(60, 23);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "English";
             
            // txtText
            this.txtText.AcceptsReturn = false;
            this.txtText.AcceptsTab = false;
            this.txtText.AnimationSpeed = 200;
            this.txtText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtText.AutoSizeHeight = true;
            this.txtText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtText.BorderColorActive = System.Drawing.Color.Silver;
            this.txtText.BorderColorDisabled = System.Drawing.Color.Silver;
            this.txtText.BorderColorHover = System.Drawing.Color.Silver;
            this.txtText.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtText.BorderRadius = 25;
            this.txtText.BorderThickness = 1;
            this.txtText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.DefaultFont = new System.Drawing.Font("Segoe UI", 14F);
            this.txtText.DefaultText = "";
            this.txtText.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.txtText.HideSelection = true;
            this.txtText.IconLeft = null;
            this.txtText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.IconPadding = 10;
            this.txtText.IconRight = null;
            this.txtText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtText.Lines = new string[0];
            this.txtText.Location = new System.Drawing.Point(106, 241);
            this.txtText.MaxLength = 32767;
            this.txtText.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtText.Modified = false;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Padding = new System.Windows.Forms.Padding(3);
            this.txtText.PasswordChar = '\0';
            this.txtText.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtText.PlaceholderText = "Enter or paste your text here to check it for grammar mistakes ...";
            this.txtText.ReadOnly = false;
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(871, 382);
            this.txtText.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtText.TabIndex = 0;
            this.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtText.TextMarginBottom = 0;
            this.txtText.TextMarginLeft = 3;
            this.txtText.TextMarginTop = 1;
            this.txtText.TextPlaceholder = "Enter or paste your text here to check it for grammar mistakes ...";
            this.txtText.UseSystemPasswordChar = false;
            this.txtText.WordWrap = true;
            this.txtText.TextChanged += new EventHandler(txtText_TextChanged);

            // lblmis
            this.lblmis.AllowParentOverrides = false;
            this.lblmis.AutoEllipsis = false;
            this.lblmis.CursorType = null;
            this.lblmis.Font = new System.Drawing.Font("Comfortaa SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblmis.ForeColor = System.Drawing.Color.DimGray;
            this.lblmis.Location = new System.Drawing.Point(105, 168);
            this.lblmis.Name = "lblmis";
            this.lblmis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblmis.Size = new System.Drawing.Size(147, 38);
            this.lblmis.TabIndex = 3;
            this.lblmis.Text = "No mistakes";
            this.lblmis.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblmis.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            // pnlMistake
            this.pnlMistake.Controls.Add(lblmis);
            this.pnlMistake.Location = new System.Drawing.Point(985, 242);
            this.pnlMistake.Size = new System.Drawing.Size(371, 381);
            this.pnlMistake.MaximumSize = new System.Drawing.Size(371, 381);
            this.pnlMistake.AutoScroll = false;
            this.pnlMistake.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMistake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMistake.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlMistake.BorderRadius = 25;
            this.pnlMistake.BorderThickness = 1;
            this.pnlMistake.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMistake.Name = "pnlMistake";
            this.pnlMistake.ShowBorders = true;

            // lblMistake
            this.lblMistake.AutoSize = true;
            this.lblMistake.BackColor = System.Drawing.Color.White;
            this.lblMistake.Font = new System.Drawing.Font("Comfortaa Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMistake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.lblMistake.Location = new System.Drawing.Point(906, 439);
            this.lblMistake.Name = "lblMistake";
            this.lblMistake.Size = new System.Drawing.Size(80, 28);
            this.lblMistake.TabIndex = 0;
            this.lblMistake.Text = "Mistake";
             
            // lblCountMistake
            this.lblCountMistake.AutoSize = true;
            this.lblCountMistake.BackColor = System.Drawing.Color.White;
            this.lblCountMistake.Font = new System.Drawing.Font("Comfortaa Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMistake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(140)))));
            this.lblCountMistake.Location = new System.Drawing.Point(992, 441);
            this.lblCountMistake.Name = "lblCountMistake";
            this.lblCountMistake.Size = new System.Drawing.Size(18, 26);
            this.lblCountMistake.TabIndex = 0;
            this.lblCountMistake.Text = "1";
            
            // btnInser
            this.btnInsert.AllowAnimations = true;
            this.btnInsert.AllowMouseEffects = true;
            this.btnInsert.AllowToggling = false;
            this.btnInsert.AnimationSpeed = 300;
            this.btnInsert.AutoGenerateColors = false;
            this.btnInsert.AutoRoundBorders = false;
            this.btnInsert.AutoSizeLeftIcon = true;
            this.btnInsert.AutoSizeRightIcon = true;
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnInsert.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsert.ButtonText = "Insert file text";
            this.btnInsert.ButtonTextMarginLeft = 0;
            this.btnInsert.ColorContrastOnClick = 45;
            this.btnInsert.ColorContrastOnHover = 45;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInsert.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsert.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsert.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInsert.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnInsert.Font = new System.Drawing.Font("Comfortaa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsert.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnInsert.IconMarginLeft = 11;
            this.btnInsert.IconPadding = 10;
            this.btnInsert.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInsert.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInsert.IconSize = 25;
            this.btnInsert.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnInsert.IdleBorderRadius = 15;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnInsert.IdleIconLeftImage = null;
            this.btnInsert.IdleIconRightImage = null;
            this.btnInsert.IndicateFocus = false;
            this.btnInsert.Location = new System.Drawing.Point(272, 435);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInsert.OnDisabledState.BorderRadius = 15;
            this.btnInsert.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsert.OnDisabledState.BorderThickness = 1;
            this.btnInsert.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInsert.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInsert.OnDisabledState.IconLeftImage = null;
            this.btnInsert.OnDisabledState.IconRightImage = null;
            this.btnInsert.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(240)))));
            this.btnInsert.onHoverState.BorderRadius = 15;
            this.btnInsert.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsert.onHoverState.BorderThickness = 1;
            this.btnInsert.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(240)))));
            this.btnInsert.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInsert.onHoverState.IconLeftImage = null;
            this.btnInsert.onHoverState.IconRightImage = null;
            this.btnInsert.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnInsert.OnIdleState.BorderRadius = 15;
            this.btnInsert.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsert.OnIdleState.BorderThickness = 1;
            this.btnInsert.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btnInsert.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInsert.OnIdleState.IconLeftImage = null;
            this.btnInsert.OnIdleState.IconRightImage = null;
            this.btnInsert.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(240)))));
            this.btnInsert.OnPressedState.BorderRadius = 15;
            this.btnInsert.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnInsert.OnPressedState.BorderThickness = 1;
            this.btnInsert.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(240)))));
            this.btnInsert.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInsert.OnPressedState.IconLeftImage = null;
            this.btnInsert.OnPressedState.IconRightImage = null;
            this.btnInsert.Size = new System.Drawing.Size(140, 34);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInsert.TextMarginLeft = 0;
            this.btnInsert.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnInsert.UseDefaultRadiusAndThickness = true;
            this.btnInsert.Click += new EventHandler(btnInsert_Click);

            // loader
            this.loader.AllowStylePresets = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loader.Color = System.Drawing.Color.DodgerBlue;
            this.loader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loader.Customization = "";
            this.loader.DashWidth = 1F;
            this.loader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loader.Image = null;
            this.loader.Location = new System.Drawing.Point(848, 443);
            this.loader.Margin = new System.Windows.Forms.Padding(0);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(20, 20);
            this.loader.Speed = 8;
            this.loader.TabIndex = 2;
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 6;
            this.loader.Transparent = true;
            this.loader.Visible = false; 

            // lblLoder
            this.lblLoder.AutoSize = true;
            this.lblLoder.BackColor = System.Drawing.Color.White;
            this.lblLoder.Font = new System.Drawing.Font("Comfortaa Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.lblLoder.Location = new System.Drawing.Point(717, 442);
            this.lblLoder.Name = "lblLoder";
            this.lblLoder.Size = new System.Drawing.Size(125, 24);
            this.lblLoder.TabIndex = 0;
            this.lblLoder.Text = "Checking text...";
            this.lblLoder.Visible = false;

            timer.Interval = 800;
            timer.Tick += timer_Tick;
            timer.Stop();

            txtText.AutoScroll = true;
            pnlMistake.AutoScroll = true;

            lblCountWord.Text = lblCountCharacter.Text = lblCountMistake.Text = "0";

            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            timer2.Stop();

            inserareDicionar();
        }

        int ct = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            this.loader.Visible = true;
            this.lblLoder.Visible = true;
            if (ct == 1)
            {
                timer.Stop();
                ct = 0;
                verificareText();
                locationPnl();
                this.loader.Visible = false;
                this.lblLoder.Visible = false;
            }
            else
            {
                ct++;
            }

        }

        private void this_SizeChanged(object sender, EventArgs e)
        {

            this.pnlDark.Size = new Size(this.Size.Width + 52, this.Size.Height - 282);
            this.pnlWhite.Size = new Size(this.Size.Width + 52, this.Size.Height);

            this.pnlMain1.Size = new Size(this.Size.Width - 151, this.Size.Height - 444);
            this.pnlMain2.Size = new Size(this.Size.Width - 133, this.Size.Height - 233);

            this.lblTile.Location = new Point(this.Size.Width/2-this.lblTile.Location.X/2+70, 22);

            this.pctFlag.Location = new Point(31, 13);

            this.txtText.Size = new Size(this.Size.Width-559,this.Size.Height-334);

            this.pnlMistake.Location = new Point(this.txtText.Size.Width + 110,this.pnlMistake.Location.Y);
            this.pnlMistake.Size = new Size(this.pnlMistake.Width,this.Size.Height - 333);

            this.lblCharacter.Location = new Point(this.lblCharacter.Location.X,this.pnlMain2.Size.Height-46);
            this.lblCountCharacter.Location = new Point(this.lblCountCharacter.Location.X, this.pnlMain2.Size.Height - 46);
            this.lblWord.Location = new Point(this.lblWord.Location.X, this.pnlMain2.Size.Height - 46);
            this.lblCountWord.Location = new Point(this.lblCountWord.Location.X, this.pnlMain2.Size.Height - 46);
            this.lblMistake.Location = new Point(this.pnlMain2.Size.Width-398, this.pnlMain2.Size.Height - 46);
            this.lblCountMistake.Location = new Point(this.pnlMain2.Size.Width - 312, this.pnlMain2.Size.Height - 46);
            this.btnInsert.Location = new Point(this.btnInsert.Location.X, this.pnlMain2.Size.Height - 50);

            float po = txtText.Size.Width/100;
            this.txtText.DefaultFont = new System.Drawing.Font("Segoe UI", po+5);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
                openFileDialog.Title = "Selectează un fișier text .txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caleFisier = openFileDialog.FileName;

                    string continutFisier = File.ReadAllText(caleFisier);

                   // Console.WriteLine("Fișier selectat: " + caleFisier);
                    txtText.Text = continutFisier;

                }
            }
        }

        private void inserareDicionar()
        {

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/words_alpha.txt");

            string t = "";

            while ((t = streamReader.ReadLine())!=null)
            {
                int key = t[0];
                hashTable.Put(key,t);

            }

            streamReader.Close();

            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + @"/data/numbers.txt");

            string numbers = "";
            for(int i = 0; i < 10000; i++)
            {
                numbers += i + "\n";
            }

            streamWriter.Write(numbers);
        }

        private void verificareText()
        {
            cuvinte.Clear();

            string t = txtText.Text;
            t = Regex.Replace(t, @"\s+", " ");

            List<string> c = new List<string>();

            for (int i = 0; i < t.Split(' ').Length; i++)
            {
                    c.Add(t.Split(' ')[i]);
            }

            foreach (var cuv in c)
            {
                if (!string.IsNullOrWhiteSpace(cuv))
                {
                    cuvinte.Add(cuv);
                }
            }

            for (int i = 0; i < cuvinte.Count; i++)
            {

                for (int k = 0; k < cuvinte[i].Length; k++)
                {
                    if ((cuvinte[i][k] >= 33 && cuvinte[i][k] <= 47) || (cuvinte[i][k] >= 58 && cuvinte[i][k] <= 64))
                    {
                        cuvinte[i] = cuvinte[i].Remove(k);
                    }
                }
            }

            cuvGresite.Clear();
            cuvGresite = hashTable.verificareOrtografica(cuvinte);
            string text = "";
            pnlsMistake.Clear();
            pnlMistake.Controls.Clear();

            for (int i = 0; i < cuvGresite.Count; i++)
            {
                text += cuvGresite[i] + "\n\n\n";
                Console.WriteLine($"Cuvânt greșit! Sugestii de corectare:");

                var sugestii = hashTable.SugestiiCorectii(cuvGresite[i]);

                PnlCards pnlCards = new PnlCards(form, cuvGresite[i],sugestii);
                pnlCards.btn.Click += btnPnl_Click;
                pnlCards.lblcuv.Click += btnPnl_Click;
                pnlCards.pct.Click += btnPnl_Click;

                pnlCards.btn1.Click += btns_Click;
                pnlCards.btn2.Click += btns_Click;
                pnlCards.btn3.Click += btns_Click;

                this.pnlsMistake.Add(pnlCards);
                this.pnlMistake.Controls.Add(pnlCards);
            }

            this.pnlMistake.Text = text;

            if (pnlsMistake.Count == 0)
            {
                pnlMistake.Controls.Clear();
                pnlMistake.Controls.Add(lblmis);

            }

            lblCountWord.Text = cuvinte.Count.ToString();
            lblCountCharacter.Text = t.Length.ToString();
            lblCountMistake.Text = cuvGresite.Count.ToString();
        }

        public void locationPnl()
        {
            if (pnlsMistake.Count >= 1)
            {
                pnlsMistake[0].Location = new Point(10, 17);

                for (int i = 1; i < pnlsMistake.Count; i++)
                {
                    pnlsMistake[i].Location = new Point(10, pnlsMistake[i - 1].Location.Y + pnlsMistake[i - 1].Size.Height + 5);
                }
                this.lblmis.Visible = false;
            }
            else
            {
                this.lblmis.Visible = true;
            }
           
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        PnlCards pnl = null;

        private void btnPnl_Click(object sender, EventArgs e)
        {
            if (sender is Control clickedControl)
            {
                if (clickedControl.Parent is PnlCards controlPanel)
                {
                    pnl = controlPanel;
                }
            }
            
            int startIndex = txtText.Text.IndexOf(pnl.lblcuv.Text);

            if (startIndex != -1)
            {
                txtText.SelectionStart = startIndex;
                txtText.SelectionLength = pnl.lblcuv.Text.Length;

                int startLocation = txtText.GetPositionFromCharIndex(startIndex).X;
                int cuvantWidth = TextRenderer.MeasureText(pnl.lblcuv.Text, txtText.Font).Width;

                using (Graphics g = txtText.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Blue, 1);
                    g.DrawLine(pen, startLocation, txtText.Bottom - 1, startLocation + cuvantWidth, txtText.Bottom - 1);
                }

                ControlPaint.DrawBorder(txtText.CreateGraphics(), txtText.ClientRectangle,
                        Color.Blue, ButtonBorderStyle.Solid);
            }
            timer2.Start();

        }

        int nr = 7;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pnl.Tag == "close")
            {
                if (pnl.Size.Height >= pnl.MaximumSize.Height)
                {
                    pnl.Tag = "open";
                    timer2.Stop();
                    pnl = null;
                }
                else
                {
                    pnl.Size = new Size(pnl.Size.Width, pnl.Size.Height + nr);
                    locationPnl();
                }
            }
            else if (pnl.Tag == "open")
            {
                if (pnl.Size.Height <= pnl.MinimumSize.Height)
                {
                    pnl.Tag = "close";
                    timer2.Stop();
                    pnl = null;
                }
                else
                {
                    pnl.Size = new Size(pnl.Size.Width, pnl.Size.Height - nr);
                    locationPnl();
                }
            }

        }

        private void btns_Click(object sender, EventArgs e)
        {
            BunifuButton2 btn = (BunifuButton2)sender;
            string cuvGresit = "";
            PnlCards card=null;
            if (sender is Control clickedControl)
            {
                if (clickedControl.Parent is PnlCards controlPanel)
                {
                    card = controlPanel;
                    cuvGresit= controlPanel.cuvGresit;
                }
            }

            if (btn != null)
            {
                string text = txtText.Text;
                string t = "";
                for(int i = 0; i < text.Split(' ').Length; i++)
                {
                    if (text.Split(' ')[i] == cuvGresit)
                        t += btn.Text + " ";
                    else t += text.Split(' ')[i] + " ";

                }

                txtText.Text = t;

                for(int i=0;i<cuvinte.Count;i++)
                {
                    if (cuvinte[i] == cuvGresit)
                    {
                        cuvinte[i] = btn.Text;
                        break;
                    }
                }

                for(int i = 0; i < cuvGresite.Count; i++)
                {
                    if (cuvGresite[i] == cuvGresit)
                    {
                        cuvGresit.Remove(i);
                        break;
                    }
                }
                this.pnlMistake.Controls.Clear();
                this.pnlMistake.Controls.Add(lblmis);
                for(int i=0;i<pnlsMistake.Count;i++)
                {
                    if (pnlsMistake[i].cuvGresit == cuvGresit)
                    {
                        pnlsMistake.Remove(card);
                    }
                    else
                    {
                        this.pnlMistake.Controls.Add(pnlsMistake[i]);
                    }
                }

            }
        }

    }
}
