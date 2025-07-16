using XCharts.Runtime;

namespace XCharts.Editor
{
    [SerieEditor(typeof(Heatmap))]
    public class HeatmapEditor : SerieEditor<Heatmap>
    {
        public override void OnCustomInspectorGUI()
        {
            if (serie.IsUseCoord<PolarCoord>())
            {
                PropertyField("m_PolarIndex");
            }
            else
            {
                PropertyField("m_XAxisIndex");
                PropertyField("m_YAxisIndex");
            }
            PropertyField("m_HeatmapType");
            PropertyField("m_Ignore");
            PropertyField("m_IgnoreValue");
            var m_TooltipCutoffEnable = baseProperty.FindPropertyRelative("m_TooltipCutoffEnable");
            PropertyField(m_TooltipCutoffEnable);
            if (m_TooltipCutoffEnable.boolValue)
            {
                PropertyField("m_TooltipCutoffComparison");
                PropertyField("m_TooltipCutoffValue");
            }
            PropertyField("m_MaxCache");


            PropertyField("m_Symbol");
            PropertyField("m_ItemStyle");
            PropertyField("m_Animation");
        }
    }
}
