using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an item object.
/// </summary>
public class Item : NdapiObject<Item>
{
    /// <summary>
    /// Creates an item object.
    /// </summary>
    /// <param name="block">Item owner.</param>
    /// <param name="name">Item name.</param>
    public Item(Block block, string name) : base(name, ObjectType.Item, block)
    {
    }

    /// <summary>
    /// Creates an item object.
    /// </summary>
    /// <param name="group">Item owner.</param>
    /// <param name="name">Item name.</param>
    public Item(ObjectGroup group, string name) : base(name, ObjectType.Item, group)
    {
    }

    internal Item(ObjectSafeHandle handle) : base(handle, ObjectType.Item)
    {
    }

    /// <summary>
    /// Gets or sets the access key.
    /// </summary>
    [Property(NdapiConstant.D2FP_ACCESS_KEY)]
    public string AccessKey
    {
        get => GetStringProperty(NdapiConstant.D2FP_ACCESS_KEY);
        set => SetStringProperty(NdapiConstant.D2FP_ACCESS_KEY, value);
    }

    /// <summary>
    /// Gets or sets the audio channels.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUDIO_CHNNLS)]
    public SoundChannels AudioChannels
    {
        get => GetNumberProperty<SoundChannels>(NdapiConstant.D2FP_AUDIO_CHNNLS);
        set => SetNumberProperty(NdapiConstant.D2FP_AUDIO_CHNNLS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display the <see cref="Hint"/> automatically.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_HINT)]
    public bool DisplayHintAutomatically
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_AUTO_HINT);
        set => SetBooleanProperty(NdapiConstant.D2FP_AUTO_HINT, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should skip to the next item when the user fill the field.
    /// </summary>
    [Property(NdapiConstant.D2FP_AUTO_SKP)]
    public bool AutoSkip
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_AUTO_SKP);
        set => SetBooleanProperty(NdapiConstant.D2FP_AUTO_SKP, value);
    }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_BACK_COLOR)]
    public string BackgroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_BACK_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the appearance of the object border.
    /// </summary>
    [Property(NdapiConstant.D2FP_BEVEL)]
    public Bevel Bevel
    {
        get => GetNumberProperty<Bevel>(NdapiConstant.D2FP_BEVEL);
        set => SetNumberProperty(NdapiConstant.D2FP_BEVEL, value);
    }

    /// <summary>
    /// Gets or sets the calculation mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_CALC_MODE)]
    public CalculationMode CalculationMode
    {
        get => GetNumberProperty<CalculationMode>(NdapiConstant.D2FP_CALC_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_CALC_MODE, value);
    }

    /// <summary>
    /// Gets or sets whether query is case insensitive.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_INSENSITIVE_QRY)]
    public bool IsCaseInsensitiveQuery
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_CASE_INSENSITIVE_QRY);
        set => SetBooleanProperty(NdapiConstant.D2FP_CASE_INSENSITIVE_QRY, value);
    }

    /// <summary>
    /// Gets or sets the case restriction.
    /// </summary>
    [Property(NdapiConstant.D2FP_CASE_RSTRCTION)]
    public CaseRestriction CaseRestriction
    {
        get => GetNumberProperty<CaseRestriction>(NdapiConstant.D2FP_CASE_RSTRCTION);
        set => SetNumberProperty(NdapiConstant.D2FP_CASE_RSTRCTION, value);
    }

    /// <summary>
    /// Gets or sets the checked value.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHKED_VAL)]
    public string Checked
    {
        get => GetStringProperty(NdapiConstant.D2FP_CHKED_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_CHKED_VAL, value);
    }

    /// <summary>
    /// Gets or sets the checkbox other values.
    /// </summary>
    [Property(NdapiConstant.D2FP_CHK_BX_OTHER_VALS)]
    public CheckBoxOtherValues CheckBoxOtherValues
    {
        get => GetNumberProperty<CheckBoxOtherValues>(NdapiConstant.D2FP_CHK_BX_OTHER_VALS);
        set => SetNumberProperty(NdapiConstant.D2FP_CHK_BX_OTHER_VALS, value);
    }

    /// <summary>
    /// Gets or sets the audio compression quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_CMPRSSION_QLTY)]
    public CompressionQuality CompressionQuality
    {
        get => GetNumberProperty<CompressionQuality>(NdapiConstant.D2FP_CMPRSSION_QLTY);
        set => SetNumberProperty(NdapiConstant.D2FP_CMPRSSION_QLTY, value);
    }

    /// <summary>
    /// Gets or sets the canvas.
    /// </summary>
    [Property(NdapiConstant.D2FP_CNV_OBJ)]
    public Canvas Canvas
    {
        get => GetObjectProperty<Canvas>(NdapiConstant.D2FP_CNV_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_CNV_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the database column name.
    /// </summary>
    [Property(NdapiConstant.D2FP_COL_NAM)]
    public string ColumnName
    {
        get => GetStringProperty(NdapiConstant.D2FP_COL_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_COL_NAM, value);
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public string Comments
    {
        get => GetStringProperty(NdapiConstant.D2FP_COMMENT);
        set => SetStringProperty(NdapiConstant.D2FP_COMMENT, value);
    }

    /// <summary>
    /// Gets or sets the communication mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMM_MODE)]
    public CommunicationMode CommunicationMode
    {
        get => GetNumberProperty<CommunicationMode>(NdapiConstant.D2FP_COMM_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_COMM_MODE, value);
    }

    /// <summary>
    /// Gets or sets the sound compression.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMPRESS)]
    public SoundCompression Compress
    {
        get => GetNumberProperty<SoundCompression>(NdapiConstant.D2FP_COMPRESS);
        set => SetNumberProperty(NdapiConstant.D2FP_COMPRESS, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should hide the text entered in the field.
    /// </summary>
    [Property(NdapiConstant.D2FP_CONCEAL_DATA)]
    public bool ConcealData
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_CONCEAL_DATA);
        set => SetBooleanProperty(NdapiConstant.D2FP_CONCEAL_DATA, value);
    }

    /// <summary>
    /// Gets or sets the name of the item to copy value from.
    /// </summary>
    [Property(NdapiConstant.D2FP_COPY_VAL_FROM_ITM)]
    public string CopyValueFromItem
    {
        get => GetStringProperty(NdapiConstant.D2FP_COPY_VAL_FROM_ITM);
        set => SetStringProperty(NdapiConstant.D2FP_COPY_VAL_FROM_ITM, value);
    }

    /// <summary>
    /// Gets or sets the name of the data source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_BLK)]
    public string DataSourceBlock
    {
        get => GetStringProperty(NdapiConstant.D2FP_DAT_SRC_BLK);
        set => SetStringProperty(NdapiConstant.D2FP_DAT_SRC_BLK, value);
    }

    /// <summary>
    /// Gets or sets the data source X axis.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_X_AXS)]
    public string DataSourceXAxis
    {
        get => GetStringProperty(NdapiConstant.D2FP_DAT_SRC_X_AXS);
        set => SetStringProperty(NdapiConstant.D2FP_DAT_SRC_X_AXS, value);
    }

    /// <summary>
    /// Gets or sets the data source Y axis.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_SRC_Y_AXS)]
    public string DataSourceYAxis
    {
        get => GetStringProperty(NdapiConstant.D2FP_DAT_SRC_Y_AXS);
        set => SetStringProperty(NdapiConstant.D2FP_DAT_SRC_Y_AXS, value);
    }

    /// <summary>
    /// Gets or sets the data type.
    /// </summary>
    [Property(NdapiConstant.D2FP_DAT_TYP)]
    public ItemDataType DataType
    {
        get => GetNumberProperty<ItemDataType>(NdapiConstant.D2FP_DAT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_DAT_TYP, value);
    }

    /// <summary>
    /// Gets or sets whether the item is a database item.
    /// </summary>
    [Property(NdapiConstant.D2FP_DB_ITM)]
    public bool IsDatabaseItem
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DB_ITM);
        set => SetBooleanProperty(NdapiConstant.D2FP_DB_ITM, value);
    }

    /// <summary>
    /// Gets or sets whther the item should be identified as the default button.
    /// </summary>
    [Property(NdapiConstant.D2FP_DFLT_BTN)]
    public bool IsDefaultButton
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_DFLT_BTN);
        set => SetBooleanProperty(NdapiConstant.D2FP_DFLT_BTN, value);
    }

    /// <summary>
    /// Gets or sets the display quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_DISP_QLTY)]
    public DisplayQuality DisplayQuality
    {
        get => GetNumberProperty<DisplayQuality>(NdapiConstant.D2FP_DISP_QLTY);
        set => SetNumberProperty(NdapiConstant.D2FP_DISP_QLTY, value);
    }

    /// <summary>
    /// Gets or sets the distance between record.
    /// </summary>
    [Property(NdapiConstant.D2FP_DIST_BTWN_RECS)]
    public int DistanceBetweenRecords
    {
        get => GetNumberProperty(NdapiConstant.D2FP_DIST_BTWN_RECS);
        set => SetNumberProperty(NdapiConstant.D2FP_DIST_BTWN_RECS, value);
    }

    /// <summary>
    /// Gets or sets the editor.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_OBJ)]
    public Editor Editor
    {
        get => GetObjectProperty<Editor>(NdapiConstant.D2FP_EDT_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_EDT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the X position of the editor measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_X_POS)]
    public int EditorXPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_EDT_X_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_EDT_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position of the editor measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_EDT_Y_POS)]
    public int EditorYPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_EDT_Y_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_EDT_Y_POS, value);
    }

    /// <summary>
    /// Gets or sets whether item is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_ENABLED)]
    public bool IsEnabled
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ENABLED);
        set => SetBooleanProperty(NdapiConstant.D2FP_ENABLED, value);
    }

    /// <summary>
    /// Gets or sets the execution mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EXEC_MODE)]
    public ExecutionMode ExecutionMode
    {
        get => GetNumberProperty<ExecutionMode>(NdapiConstant.D2FP_EXEC_MODE);
        set => SetNumberProperty(NdapiConstant.D2FP_EXEC_MODE, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the fill region.
    /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_FILL_PAT)]
    public string FillPattern
    {
        get => GetStringProperty(NdapiConstant.D2FP_FILL_PAT);
        set => SetStringProperty(NdapiConstant.D2FP_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the fixed length.
    /// </summary>
    [Property(NdapiConstant.D2FP_FIXED_LEN)]
    public bool IsFixedLength
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_FIXED_LEN);
        set => SetBooleanProperty(NdapiConstant.D2FP_FIXED_LEN, value);
    }

    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    [Property(NdapiConstant.D2FP_FLNAM)]
    public string FileName
    {
        get => GetStringProperty(NdapiConstant.D2FP_FLNAM);
        set => SetStringProperty(NdapiConstant.D2FP_FLNAM, value);
    }

    /// <summary>
    /// Gets or sets the format masl.
    /// </summary>
    [Property(NdapiConstant.D2FP_FMT_MSK)]
    public string FormatMask
    {
        get => GetStringProperty(NdapiConstant.D2FP_FMT_MSK);
        set => SetStringProperty(NdapiConstant.D2FP_FMT_MSK, value);
    }

    /// <summary>
    /// Gets or sets the font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_NAM)]
    public string FontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SIZ)]
    public int FontSize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_FONT_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_SPCING)]
    public FontSpacing FontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstant.D2FP_FONT_SPCING);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_STY)]
    public FontStyle FontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstant.D2FP_FONT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_FONT_WGHT)]
    public FontWeight FontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstant.D2FP_FONT_WGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORE_COLOR)]
    public string ForegroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_FORE_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the formula.
    /// </summary>
    [Property(NdapiConstant.D2FP_FORMULA)]
    public string Formula
    {
        get => GetStringProperty(NdapiConstant.D2FP_FORMULA);
        set => SetStringProperty(NdapiConstant.D2FP_FORMULA, value);
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    [Property(NdapiConstant.D2FP_HEIGHT)]
    public int Height
    {
        get => GetNumberProperty(NdapiConstant.D2FP_HEIGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_HEIGHT, value);
    }

    /// <summary>
    /// Gets or sets the help book topic.
    /// </summary>
    [Property(NdapiConstant.D2FP_HELP_BOOK_TOPIC)]
    public string HelpBookTopic
    {
        get => GetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TOPIC);
        set => SetStringProperty(NdapiConstant.D2FP_HELP_BOOK_TOPIC, value);
    }

    /// <summary>
    /// Gets or sets the highest allowed value.
    /// </summary>
    [Property(NdapiConstant.D2FP_HIGHEST_ALLOWED_VAL)]
    public string HighestAllowedValue
    {
        get => GetStringProperty(NdapiConstant.D2FP_HIGHEST_ALLOWED_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_HIGHEST_ALLOWED_VAL, value);
    }

    /// <summary>
    /// Gets or sets the hint.
    /// </summary>
    [Property(NdapiConstant.D2FP_HINT)]
    public string Hint
    {
        get => GetStringProperty(NdapiConstant.D2FP_HINT);
        set => SetStringProperty(NdapiConstant.D2FP_HINT, value);
    }

    /// <summary>
    /// Gets or sets whether button is iconic.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICONIC)]
    public bool IsIconic
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_ICONIC);
        set => SetBooleanProperty(NdapiConstant.D2FP_ICONIC, value);
    }

    /// <summary>
    /// Gets or sets the icon file name.
    /// </summary>
    [Property(NdapiConstant.D2FP_ICON_FLNAM)]
    public string IconFilename
    {
        get => GetStringProperty(NdapiConstant.D2FP_ICON_FLNAM);
        set => SetStringProperty(NdapiConstant.D2FP_ICON_FLNAM, value);
    }

    /// <summary>
    /// Gets or sets the image depth.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMG_DPTH)]
    public ImageDepth ImageDepth
    {
        get => GetNumberProperty<ImageDepth>(NdapiConstant.D2FP_IMG_DPTH);
        set => SetNumberProperty(NdapiConstant.D2FP_IMG_DPTH, value);
    }

    /// <summary>
    /// Gets or sets the image format.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMG_FMT)]
    public ImageFormat ImageFormat
    {
        get => GetNumberProperty<ImageFormat>(NdapiConstant.D2FP_IMG_FMT);
        set => SetNumberProperty(NdapiConstant.D2FP_IMG_FMT, value);
    }

    /// <summary>
    /// Gets or sets the implementation class.
    /// </summary>
    [Property(NdapiConstant.D2FP_IMPL_CLASS)]
    public string ImplementationClass
    {
        get => GetStringProperty(NdapiConstant.D2FP_IMPL_CLASS);
        set => SetStringProperty(NdapiConstant.D2FP_IMPL_CLASS, value);
    }

    /// <summary>
    /// Gets or sets the initial keyboard direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_KBRD_DIR)]
    public InitialKeyboardDirection InitialKeyboardDirection
    {
        get => GetNumberProperty<InitialKeyboardDirection>(NdapiConstant.D2FP_INIT_KBRD_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_INIT_KBRD_DIR, value);
    }

    /// <summary>
    /// Gets or sets the initial value.
    /// </summary>
    [Property(NdapiConstant.D2FP_INIT_VAL)]
    public string InitialValue
    {
        get => GetStringProperty(NdapiConstant.D2FP_INIT_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_INIT_VAL, value);
    }

    /// <summary>
    /// Gets or sets whether runtime allows inserting of data.
    /// </summary>
    [Property(NdapiConstant.D2FP_INSRT_ALLOWED)]
    public bool IsInsertAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_INSRT_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_INSRT_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the number of items displayed.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITMS_DISP)]
    public int NumberOfItemsDisplayed
    {
        get => GetNumberProperty(NdapiConstant.D2FP_ITMS_DISP);
        set => SetNumberProperty(NdapiConstant.D2FP_ITMS_DISP, value);
    }

    /// <summary>
    /// Gets or sets the item type.
    /// </summary>
    [Property(NdapiConstant.D2FP_ITM_TYP)]
    public ItemType ItemType
    {
        get => GetNumberProperty<ItemType>(NdapiConstant.D2FP_ITM_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_ITM_TYP, value);
    }

    /// <summary>
    /// Gets or sets the justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_JUSTIFICATION)]
    public Justification Justification
    {
        get => GetNumberProperty<Justification>(NdapiConstant.D2FP_JUSTIFICATION);
        set => SetNumberProperty(NdapiConstant.D2FP_JUSTIFICATION, value);
    }

    /// <summary>
    /// Gets or sets whether the field is navigable with keyboard.
    /// </summary>
    [Property(NdapiConstant.D2FP_KBRD_NAVIGABLE)]
    public bool IsKeyboardNavigable
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_KBRD_NAVIGABLE);
        set => SetBooleanProperty(NdapiConstant.D2FP_KBRD_NAVIGABLE, value);
    }

    /// <summary>
    /// Gets or sets whether field should keep the last cursor position.
    /// </summary>
    [Property(NdapiConstant.D2FP_KEEP_CRSR_POS)]
    public bool KeepCursorPosition
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_KEEP_CRSR_POS);
        set => SetBooleanProperty(NdapiConstant.D2FP_KEEP_CRSR_POS, value);
    }

    /// <summary>
    /// Gets or sets the label.
    /// </summary>
    [Property(NdapiConstant.D2FP_LABEL)]
    public string Label
    {
        get => GetStringProperty(NdapiConstant.D2FP_LABEL);
        set => SetStringProperty(NdapiConstant.D2FP_LABEL, value);
    }

    /// <summary>
    /// Gets or sets the language direction.
    /// </summary>
    [Property(NdapiConstant.D2FP_LANG_DIR)]
    public LanguageDirection LanguageDirection
    {
        get => GetNumberProperty<LanguageDirection>(NdapiConstant.D2FP_LANG_DIR);
        set => SetNumberProperty(NdapiConstant.D2FP_LANG_DIR, value);
    }

    /// <summary>
    /// Gets or sets whether item should lock record.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOCK_REC)]
    public bool LockRecord
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_LOCK_REC);
        set => SetBooleanProperty(NdapiConstant.D2FP_LOCK_REC, value);
    }

    /// <summary>
    /// Gets or sets the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_OBJ)]
    public LOV LOV
    {
        get => GetObjectProperty<LOV>(NdapiConstant.D2FP_LOV_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_LOV_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the name of the list of values.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_NAM)]
    public string LOVName
    {
        get => GetStringProperty(NdapiConstant.D2FP_LOV_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_LOV_NAM, value);
    }

    /// <summary>
    /// Gets or sets the X position of the list of values measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_X_POS)]
    public int LOVXPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_LOV_X_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_LOV_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the X position of the list of values measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOV_Y_POS)]
    public int LOVXYosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_LOV_Y_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_LOV_Y_POS, value);
    }

    /// <summary>
    /// Gets or sets the lowest allowed value.
    /// </summary>
    [Property(NdapiConstant.D2FP_LOWEST_ALLOWED_VAL)]
    public string LowestAllowedValue
    {
        get => GetStringProperty(NdapiConstant.D2FP_LOWEST_ALLOWED_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_LOWEST_ALLOWED_VAL, value);
    }

    /// <summary>
    /// Gets the list element count.
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_ELEMENT_COUNT)]
    public int ListElementCount => GetNumberProperty(NdapiConstant.D2FP_LST_ELEMENT_COUNT);

    /// <summary>
    /// Gets or sets the list style.
    /// </summary>
    [Property(NdapiConstant.D2FP_LST_STY)]
    public ListStyle ListStyle
    {
        get => GetNumberProperty<ListStyle>(NdapiConstant.D2FP_LST_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_LST_STY, value);
    }

    /// <summary>
    /// Gets or sets the maximum length.
    /// </summary>
    [Property(NdapiConstant.D2FP_MAX_LEN)]
    public int MaximumLength
    {
        get => GetNumberProperty(NdapiConstant.D2FP_MAX_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_MAX_LEN, value);
    }

    /// <summary>
    /// Gets or sets whether field allows multiple lines.
    /// </summary>
    [Property(NdapiConstant.D2FP_MLT_LIN)]
    public bool IsMultiLine
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MLT_LIN);
        set => SetBooleanProperty(NdapiConstant.D2FP_MLT_LIN, value);
    }

    /// <summary>
    /// Gets or sets whether item is navigable with mouse.
    /// </summary>
    [Property(NdapiConstant.D2FP_MOUSE_NAVIGATE)]
    public bool IsMouseNavigate
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_MOUSE_NAVIGATE);
        set => SetBooleanProperty(NdapiConstant.D2FP_MOUSE_NAVIGATE, value);
    }

    /// <summary>
    /// Gets or sets the next navigation item.
    /// </summary>
    [Property(NdapiConstant.D2FP_NXT_NAVIGATION_ITM_OBJ)]
    public Item NextNavigationItem
    {
        get => GetObjectProperty<Item>(NdapiConstant.D2FP_NXT_NAVIGATION_ITM_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_NXT_NAVIGATION_ITM_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the OLE activation style.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_ACT_STY)]
    public OleActivationStyle OLEActivationStyle
    {
        get => GetNumberProperty<OleActivationStyle>(NdapiConstant.D2FP_OLE_ACT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_OLE_ACT_STY, value);
    }

    /// <summary>
    /// Gets or sets the OLE class name.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_CLASS)]
    public string OLEClass
    {
        get => GetStringProperty(NdapiConstant.D2FP_OLE_CLASS);
        set => SetStringProperty(NdapiConstant.D2FP_OLE_CLASS, value);
    }

    /// <summary>
    /// Gets or sets if OLE in-place activation is used for editing embedded OLE objects.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_INSD_OUT_SUPPORT)]
    public bool OLEInsideOutSupport
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_OLE_INSD_OUT_SUPPORT);
        set => SetBooleanProperty(NdapiConstant.D2FP_OLE_INSD_OUT_SUPPORT, value);
    }

    /// <summary>
    /// Gets or sets if the OLE server of the embedded object allows inside-out object support during in-place activation.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_IN_PLACE_ACT)]
    public bool OLEInPlaceActivation
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_OLE_IN_PLACE_ACT);
        set => SetBooleanProperty(NdapiConstant.D2FP_OLE_IN_PLACE_ACT, value);
    }

    /// <summary>
    /// Gets or sets which OLE popup menu commands are displayed and enabled when the mouse cursor is on the OLE 
    /// object and and the right mouse button is pressed.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_POPUP_MNU_ITMS)]
    public int OLEPopUpMenuItems
    {
        get => GetNumberProperty(NdapiConstant.D2FP_OLE_POPUP_MNU_ITMS);
        set => SetNumberProperty(NdapiConstant.D2FP_OLE_POPUP_MNU_ITMS, value);
    }

    /// <summary>
    /// Gets or sets the OLE resize style.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_RESIZ_STY)]
    public OleResizeStyle OLEResizeStyle
    {
        get => GetNumberProperty<OleResizeStyle>(NdapiConstant.D2FP_OLE_RESIZ_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_OLE_RESIZ_STY, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display the OLE tenant type.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_SHOW_TNNT_TYP)]
    public bool ShowOLETenantType
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_OLE_SHOW_TNNT_TYP);
        set => SetBooleanProperty(NdapiConstant.D2FP_OLE_SHOW_TNNT_TYP, value);
    }

    /// <summary>
    /// Gets or sets the OLE tenant aspect.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_TNNT_ASPCT)]
    public OleTenantAspect OLETenantAspect
    {
        get => GetNumberProperty<OleTenantAspect>(NdapiConstant.D2FP_OLE_TNNT_ASPCT);
        set => SetNumberProperty(NdapiConstant.D2FP_OLE_TNNT_ASPCT, value);
    }

    /// <summary>
    /// Gets or sets the OLE tentat type.
    /// </summary>
    [Property(NdapiConstant.D2FP_OLE_TNNT_TYP)]
    public OleTenantTypes OLETenantType
    {
        get => GetNumberProperty<OleTenantTypes>(NdapiConstant.D2FP_OLE_TNNT_TYP);
        set => SetNumberProperty(NdapiConstant.D2FP_OLE_TNNT_TYP, value);
    }

    /// <summary>
    /// Gets or sets the mapping of other values.
    /// </summary>
    [Property(NdapiConstant.D2FP_OTHER_VALS)]
    public string MappingOfOtherValues
    {
        get => GetStringProperty(NdapiConstant.D2FP_OTHER_VALS);
        set => SetStringProperty(NdapiConstant.D2FP_OTHER_VALS, value);
    }

    /// <summary>
    /// Gets or sets the popup menu name.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_NAM)]
    public string PopupMenuName
    {
        get => GetStringProperty(NdapiConstant.D2FP_POPUP_MNU_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_POPUP_MNU_NAM, value);
    }

    /// <summary>
    /// Gets or sets the popup menu.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_MNU_OBJ)]
    public Menu PopupMenu
    {
        get => GetObjectProperty<Menu>(NdapiConstant.D2FP_POPUP_MNU_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_POPUP_MNU_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the popup visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_POPUP_VA_OBJ)]
    public VisualAttribute PopUpVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_POPUP_VA_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_POPUP_VA_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the previous navigation item.
    /// </summary>
    [Property(NdapiConstant.D2FP_PREV_NAVIGATION_ITM_OBJ)]
    public Item PreviousNavigationItem
    {
        get => GetObjectProperty<Item>(NdapiConstant.D2FP_PREV_NAVIGATION_ITM_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_PREV_NAVIGATION_ITM_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the prompt.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT)]
    public string Prompt
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN)]
    public Alignment PromptAlignment
    {
        get => GetNumberProperty<Alignment>(NdapiConstant.D2FP_PRMPT_ALIGN);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN, value);
    }

    /// <summary>
    /// Gets or sets the prompt alignment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ALIGN_OFST)]
    public int PromptAlignmentOffset
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN_OFST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ALIGN_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment edge.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_EDGE)]
    public EdgeAtachmentType PromptAttachmentEdge
    {
        get => GetNumberProperty<EdgeAtachmentType>(NdapiConstant.D2FP_PRMPT_ATT_EDGE);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_EDGE, value);
    }

    /// <summary>
    /// Gets or sets the prompt attachment offset.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_ATT_OFST)]
    public int PromptAttachmentOffset
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_OFST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_ATT_OFST, value);
    }

    /// <summary>
    /// Gets or sets the prompt background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_BACK_COLOR)]
    public string PromptBackgroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_BACK_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt display style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_DISP_STY)]
    public PromptDisplayStyle PromptDisplayStyle
    {
        get => GetNumberProperty<PromptDisplayStyle>(NdapiConstant.D2FP_PRMPT_DISP_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_DISP_STY, value);
    }

    /// <summary>
    /// Gets or sets the pattern to be used for the prompt's fill region.
    /// Patterns are rendered in the two colors specified by <see cref="PromptBackgroundColor"/> and <see cref="PromptForegroundColor"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FILL_PAT)]
    public string PromptFillPattern
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FILL_PAT);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FILL_PAT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_NAM)]
    public string PromptFontName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FONT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt font size.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SIZ)]
    public int PromptFontSize
    {
        get => GetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SIZ);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SIZ, value);
    }

    /// <summary>
    /// Gets or sets the prompt font spacing.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_SPCING)]
    public FontSpacing PromptFontSpacing
    {
        get => GetNumberProperty<FontSpacing>(NdapiConstant.D2FP_PRMPT_FONT_SPCING);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_SPCING, value);
    }

    /// <summary>
    /// Gets or sets the prompt font style.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_STY)]
    public FontStyle PromptFontStyle
    {
        get => GetNumberProperty<FontStyle>(NdapiConstant.D2FP_PRMPT_FONT_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_STY, value);
    }

    /// <summary>
    /// Gets or sets the prompt font weight.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FONT_WGHT)]
    public FontWeight PromptFontWeight
    {
        get => GetNumberProperty<FontWeight>(NdapiConstant.D2FP_PRMPT_FONT_WGHT);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_FONT_WGHT, value);
    }

    /// <summary>
    /// Gets or sets the prompt font foreground color.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_FORE_COLOR)]
    public string PromptForegroundColor
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_FORE_COLOR, value);
    }

    /// <summary>
    /// Gets or sets the prompt font justification.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_JST)]
    public Justification PromptJustification
    {
        get => GetNumberProperty<Justification>(NdapiConstant.D2FP_PRMPT_JST);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_JST, value);
    }

    /// <summary>
    /// Gets or sets the prompt reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_READING_ORDR)]
    public ReadingOrder PromptReadingOrder
    {
        get => GetNumberProperty<ReadingOrder>(NdapiConstant.D2FP_PRMPT_READING_ORDR);
        set => SetNumberProperty(NdapiConstant.D2FP_PRMPT_READING_ORDR, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_NAM)]
    public string PromptVisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_PRMPT_VAT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_PRMPT_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the prompt visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMPT_VAT_OBJ)]
    public VisualAttribute PromptVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_PRMPT_VAT_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_PRMPT_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets whether the item is part of the primary key.
    /// </summary>
    [Property(NdapiConstant.D2FP_PRMRY_KEY)]
    public bool IsPrimaryKey
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_PRMRY_KEY);
        set => SetBooleanProperty(NdapiConstant.D2FP_PRMRY_KEY, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should allow the end user to execute a query in the item.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ALLOWED)]
    public bool IsQueryAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_QRY_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_QRY_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets the length for entering queries.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_LEN)]
    public int QueryLength
    {
        get => GetNumberProperty(NdapiConstant.D2FP_QRY_LEN);
        set => SetNumberProperty(NdapiConstant.D2FP_QRY_LEN, value);
    }

    /// <summary>
    /// Gets or sets whether the item is query only.
    /// </summary>
    [Property(NdapiConstant.D2FP_QRY_ONLY)]
    public bool IsQueryOnly
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_QRY_ONLY);
        set => SetBooleanProperty(NdapiConstant.D2FP_QRY_ONLY, value);
    }

    /// <summary>
    /// Gets or sets the reading order.
    /// </summary>
    [Property(NdapiConstant.D2FP_READING_ORDR)]
    public ReadingOrder ReadingOrder
    {
        get => GetNumberProperty<ReadingOrder>(NdapiConstant.D2FP_READING_ORDR);
        set => SetNumberProperty(NdapiConstant.D2FP_READING_ORDR, value);
    }

    /// <summary>
    /// Gets or sets the name of the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_NAM)]
    public string CurrentRecordVisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_REC_VAT_GRP_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_REC_VAT_GRP_NAM, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute used when an item is part of the current record.
    /// </summary>
    [Property(NdapiConstant.D2FP_REC_VAT_GRP_OBJ)]
    public VisualAttribute CurrentRecordVisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_REC_VAT_GRP_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_REC_VAT_GRP_OBJ, value);
    }

    /// <summary>
    /// Gets or sets whether item is to be displayed as a rendered object when it does not have focus. 
    /// </summary>
    [Property(NdapiConstant.D2FP_RENDERED)]
    public bool IsRendered
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_RENDERED);
        set => SetBooleanProperty(NdapiConstant.D2FP_RENDERED, value);
    }

    /// <summary>
    /// Gets or sets whether item is required.
    /// </summary>
    [Property(NdapiConstant.D2FP_REQUIRED)]
    public bool IsRequired
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_REQUIRED);
        set => SetBooleanProperty(NdapiConstant.D2FP_REQUIRED, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a fast forward button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_FAST_FWD)]
    public bool ShowFastForwardButton
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_FAST_FWD);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_FAST_FWD, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a horizontal toolbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR)]
    public bool ShowHorizonatalScrollbar
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_HORZ_SCRLBR, value);
    }

#if FORMS_6
        /// <summary>
        /// Gets or sets whether runtime should display a color palette.
        /// </summary>
        [Property(NdapiConstant.D2FP_SHOW_PALETTE)]
        public bool ShowPalette
        {
            get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_PALETTE);
            set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_PALETTE, value);
        }
#endif

    /// <summary>
    /// Gets or sets whether runtime should display a play button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_PLAY)]
    public bool ShowPlayButton
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_PLAY);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_PLAY, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a record button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_REC)]
    public bool ShowRecordButton
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_REC);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_REC, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a rewind button.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_REWIND)]
    public bool ShowRewindButton
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_REWIND);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_REWIND, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a time slider.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_SLIDER)]
    public bool ShowSlider
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_SLIDER);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_SLIDER, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a time indicator.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_TIME)]
    public bool ShowTimeIndicator
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_TIME);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_TIME, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a vertical scrollbar.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VERT_SCRLBR)]
    public bool ShowVerticalScrollBar
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_VERT_SCRLBR);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_VERT_SCRLBR, value);
    }

    /// <summary>
    /// Gets or sets whether runtime should display a volume control.
    /// </summary>
    [Property(NdapiConstant.D2FP_SHOW_VOLUME)]
    public bool ShowVolumeControl
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_SHOW_VOLUME);
        set => SetBooleanProperty(NdapiConstant.D2FP_SHOW_VOLUME, value);
    }

    /// <summary>
    /// Gets or sets the sizing style.
    /// </summary>
    [Property(NdapiConstant.D2FP_SIZING_STY)]
    public ImageSizingStyle SizingStyle
    {
        get => GetNumberProperty<ImageSizingStyle>(NdapiConstant.D2FP_SIZING_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_SIZING_STY, value);
    }

    /// <summary>
    /// Gets or sets the sound format.
    /// </summary>
    [Property(NdapiConstant.D2FP_SND_FMT)]
    public SoundFormat SoundFormat
    {
        get => GetNumberProperty<SoundFormat>(NdapiConstant.D2FP_SND_FMT);
        set => SetNumberProperty(NdapiConstant.D2FP_SND_FMT, value);
    }

    /// <summary>
    /// Gets or sets the sound quality.
    /// </summary>
    [Property(NdapiConstant.D2FP_SND_QLTY)]
    public SoundQuality SoundQuality
    {
        get => GetNumberProperty<SoundQuality>(NdapiConstant.D2FP_SND_QLTY);
        set => SetNumberProperty(NdapiConstant.D2FP_SND_QLTY, value);
    }

    /// <summary>
    /// Gets or sets the name of the block to summarize.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_BLK_NAM)]
    public string SummarizedBlock
    {
        get => GetStringProperty(NdapiConstant.D2FP_SUMM_BLK_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_SUMM_BLK_NAM, value);
    }

    /// <summary>
    /// Gets or sets the summary function.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_FUNC)]
    public SummaryFunction SummarizedFunction
    {
        get => GetNumberProperty<SummaryFunction>(NdapiConstant.D2FP_SUMM_FUNC);
        set => SetNumberProperty(NdapiConstant.D2FP_SUMM_FUNC, value);
    }

    /// <summary>
    /// Gets or sets the name of the item to summarize.
    /// </summary>
    [Property(NdapiConstant.D2FP_SUMM_ITM_NAM)]
    public string SummarizedItem
    {
        get => GetStringProperty(NdapiConstant.D2FP_SUMM_ITM_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_SUMM_ITM_NAM, value);
    }

    /// <summary>
    /// Gets or sets the item to synchronize with;
    /// </summary>
    [Property(NdapiConstant.D2FP_SYNC_ITM_OBJ)]
    public Item SynchronizeWithItem
    {
        get => GetObjectProperty<Item>(NdapiConstant.D2FP_SYNC_ITM_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_SYNC_ITM_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the tab page.
    /// </summary>
    [Property(NdapiConstant.D2FP_TBP_OBJ)]
    public TabPage TabPage
    {
        get => GetObjectProperty<TabPage>(NdapiConstant.D2FP_TBP_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_TBP_OBJ, value);
    }

    /// <summary>
    /// Gets or sets the tooltip.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOOLTIP)]
    public string Tooltip
    {
        get => GetStringProperty(NdapiConstant.D2FP_TOOLTIP);
        set => SetStringProperty(NdapiConstant.D2FP_TOOLTIP, value);
    }

    /// <summary>
    /// Gets or sets the tooltip visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_TOOLTIP_VAT_GRP)]
    public string TooltipVisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_TOOLTIP_VAT_GRP);
        set => SetStringProperty(NdapiConstant.D2FP_TOOLTIP_VAT_GRP, value);
    }

    /// <summary>
    /// Gets or sets the value when unchecked.
    /// </summary>
    [Property(NdapiConstant.D2FP_UNCHKED_VAL)]
    public string ValueWhenUnchecked
    {
        get => GetStringProperty(NdapiConstant.D2FP_UNCHKED_VAL);
        set => SetStringProperty(NdapiConstant.D2FP_UNCHKED_VAL, value);
    }

    /// <summary>
    /// Gets or sets whether runtime allows the item to be updated.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_ALLOWED)]
    public bool IsUpdateAllowed
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_ALLOWED);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_ALLOWED, value);
    }

    /// <summary>
    /// Gets or sets whether a chart item is updated to reflect changes made by committing new or updated records to its source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_COMMIT)]
    public bool IsUpdateCommit
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_COMMIT);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_COMMIT, value);
    }

    /// <summary>
    /// Gets or sets whether user can modify the value of the item only when the current value of the item is NULL. 
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_IF_NULL)]
    public bool UpdateOnlyIfNull
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_IF_NULL);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_IF_NULL, value);
    }

    /// <summary>
    /// Gets or sets whether a chart item is updated to reflect changes made by querying records in its source block.
    /// </summary>
    [Property(NdapiConstant.D2FP_UPDT_QRY)]
    public bool UpdateQuery
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_UPDT_QRY);
        set => SetBooleanProperty(NdapiConstant.D2FP_UPDT_QRY, value);
    }

    /// <summary>
    /// Gets or sets whether runtime shoud validate the data entered using the values of the associated <see cref="LOV"/>.
    /// </summary>
    [Property(NdapiConstant.D2FP_VALIDATE_FROM_LST)]
    public bool ValidateFromList
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_VALIDATE_FROM_LST);
        set => SetBooleanProperty(NdapiConstant.D2FP_VALIDATE_FROM_LST, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute name.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_NAM)]
    public string VisualAttributeName
    {
        get => GetStringProperty(NdapiConstant.D2FP_VAT_NAM);
        set => SetStringProperty(NdapiConstant.D2FP_VAT_NAM, value);
    }

    /// <summary>
    /// Gets or sets the visual attribute.
    /// </summary>
    [Property(NdapiConstant.D2FP_VAT_OBJ)]
    public VisualAttribute VisualAttribute
    {
        get => GetObjectProperty<VisualAttribute>(NdapiConstant.D2FP_VAT_OBJ);
        set => SetObjectProperty(NdapiConstant.D2FP_VAT_OBJ, value);
    }

    /// <summary>
    /// Gets or sets whether item is visible.
    /// </summary>
    [Property(NdapiConstant.D2FP_VISIBLE)]
    public bool IsVisible
    {
        get => GetBooleanProperty(NdapiConstant.D2FP_VISIBLE);
        set => SetBooleanProperty(NdapiConstant.D2FP_VISIBLE, value);
    }

#if FORMS_6
        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstant.D2FP_WHITE_ON_BLACK)]
        public bool IsWhiteOnBlack
        {
            get => GetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK);
            set => SetBooleanProperty(NdapiConstant.D2FP_WHITE_ON_BLACK, value);
        }
#endif

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    [Property(NdapiConstant.D2FP_WIDTH)]
    public int Width
    {
        get => GetNumberProperty(NdapiConstant.D2FP_WIDTH);
        set => SetNumberProperty(NdapiConstant.D2FP_WIDTH, value);
    }

    /// <summary>
    /// Gets or sets the wrap style.
    /// </summary>
    [Property(NdapiConstant.D2FP_WRAP_STY)]
    public WrapStyle WrapStyle
    {
        get => GetNumberProperty<WrapStyle>(NdapiConstant.D2FP_WRAP_STY);
        set => SetNumberProperty(NdapiConstant.D2FP_WRAP_STY, value);
    }

    /// <summary>
    /// Gets or sets the X position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_X_POS)]
    public int XPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_X_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_X_POS, value);
    }

    /// <summary>
    /// Gets or sets the Y position measured at the upper left corner.
    /// </summary>
    [Property(NdapiConstant.D2FP_Y_POS)]
    public int YPosition
    {
        get => GetNumberProperty(NdapiConstant.D2FP_Y_POS);
        set => SetNumberProperty(NdapiConstant.D2FP_Y_POS, value);
    }

#if FORMS_12_OR_GREATER
    /// <summary>
    /// Gets or sets the mouse cursor style that is displayed while hovering over that object.
    /// </summary>
    [Property(NdapiConstant.D2FP_CURSOR_STYLE)]
    public CursorStyle CursorStyle
    {
        get => GetNumberProperty<CursorStyle>(NdapiConstant.D2FP_CURSOR_STYLE);
        set => SetNumberProperty(NdapiConstant.D2FP_CURSOR_STYLE, value);
    }

    /// <summary>
    /// Gets or sets the row banding frequency. When row banding is set, every n-th instance of
    /// the item would appear in a different background color.
    /// </summary>
    [Property(NdapiConstant.D2FP_ROW_BANDING_FREQ)]
    public int RowBandingFrequency
    {
        get => GetNumberProperty(NdapiConstant.D2FP_ROW_BANDING_FREQ);
        set => SetNumberProperty(NdapiConstant.D2FP_ROW_BANDING_FREQ, value);
    }
#endif

    /// <summary>
    /// Gets the radio button items.
    /// </summary>
    [Property(NdapiConstant.D2FP_RAD_BUT)]
    public NdapiObjectList<RadioButton> RadioButtons => GetObjectList<RadioButton>(NdapiConstant.D2FP_RAD_BUT);

    /// <summary>
    /// Gets the item-level triggers.
    /// </summary>
    [Property(NdapiConstant.D2FP_TRIGGER)]
    public NdapiObjectList<Trigger> Triggers => GetObjectList<Trigger>(NdapiConstant.D2FP_TRIGGER);

    /// <summary>
    /// Gets the list elements. Valid only when <see cref="ItemType"/> is <see cref="ItemType.ListItem"/>.
    /// </summary>
    public IEnumerable<KeyValuePair<string, string>> ListElements
    {
        get
        {
            for (var i = 1; i <= ListElementCount; i++) // objects index is one-based
            {
                yield return GetListElementAt(i);
            }
        }
    }

    /// <summary>
    /// Compile the item-level triggers.
    /// </summary>
    public void Compile()
    {
        var status = NativeMethods.d2fitmco_CompileObj(NdapiContext.GetContext(), _handle);
        Ensure.Success(status);
    }

    /// <summary>
    /// Inserts a list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which item should be inserted.</param>
    /// <param name="label">Element label.</param>
    /// <param name="value">Element value.</param>
    public void InsertListElementAt(int index, string label, string value)
    {
        var status = NativeMethods.d2fitmile_InsertListElem(NdapiContext.GetContext(), _handle, index, label, value);
        Ensure.Success(status);
    }

    /// <summary>
    /// Deletes the list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index at which item should be removed.</param>
    public void DeleteListElementAt(int index)
    {
        var status = NativeMethods.d2fitmdle_DeleteListElem(NdapiContext.GetContext(), _handle, index);
        Ensure.Success(status);
    }

    /// <summary>
    /// Gets the list element in the specified index.
    /// </summary>
    /// <param name="index">The one-based index of the element.</param>
    /// <returns>The label and the value of the list element.</returns>
    public KeyValuePair<string, string> GetListElementAt(int index)
    {
        var status = NativeMethods.d2fitmgle_GetListElem(NdapiContext.GetContext(), _handle, index, out var label, out var value);
        Ensure.Success(status);
        return new KeyValuePair<string, string>(label, value);
    }

    /// <summary>
    /// Creates a radio button.
    /// </summary>
    /// <param name="name">Name of the radio button.</param>
    /// <returns>The child object.</returns>
    public RadioButton CreateRadioButton(string name) => new(this, name);

    /// <summary>
    /// Creates a trigger.
    /// </summary>
    /// <param name="name">Name of the trigger.</param>
    /// <returns>The child object.</returns>
    public Trigger CreateTrigger(string name) => new(this, name);
}
