using XCharts.Runtime;

namespace XCharts.Editor
{
    [SerieEditor(typeof(SimplifiedLine))]
    public class LineHPEditor : SerieEditor<SimplifiedLine>
    {
        public override void OnCustomInspectorGUI()
        {
            PropertyField("m_XAxisIndex");
            PropertyField("m_YAxisIndex");
            PropertyField("m_LineType");
            //PropertyField("m_Clip");
            var m_TooltipCutoffEnable = baseProperty.FindPropertyRelative("m_TooltipCutoffEnable");
            PropertyField(m_TooltipCutoffEnable);
            if (m_TooltipCutoffEnable.boolValue)
            {
                PropertyField("m_TooltipCutoffComparison");
                PropertyField("m_TooltipCutoffValue");
            }
            PropertyField("m_LineStyle");
            PropertyField("m_ItemStyle");
            PropertyField("m_Animation");
        }
    }
}
