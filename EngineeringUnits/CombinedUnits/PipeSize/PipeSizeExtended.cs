using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public partial class PipeSize : BaseUnit
{
    public PipeScheduleEnum PipeSchedule { get; set; }

    public int DNValve => (int)NEWValue;

    public Length? GetOutsideDiameter => DNtoOD.GetOutsideDiameter(DNValve);
    public Length? GetInsideDiameter => DNtoOD.GetOutsideDiameter(DNValve) - 2 * GetWallThickness();
    public Area? GetInsideCrossSection => Area.FromCircleDiameter(GetInsideDiameter);

    public Length? GetWallThickness()
    {
        return PipeSchedule switch
        {
            PipeScheduleEnum.SCH_5s  => DNtoOD.GetSchedule5s(DNValve),
            PipeScheduleEnum.SCH_10  => DNtoOD.GetSchedule10(DNValve),
            PipeScheduleEnum.SCH_10s => DNtoOD.GetSchedule10s(DNValve),
            PipeScheduleEnum.SCH_30  => DNtoOD.GetSchedule30(DNValve),
            PipeScheduleEnum.SCH_40  => DNtoOD.GetSchedule40(DNValve),
            PipeScheduleEnum.SCH_40s => DNtoOD.GetSchedule40s(DNValve),
            PipeScheduleEnum.Std     => DNtoOD.GetScheduleSTD(DNValve),
            PipeScheduleEnum.SCH_80  => DNtoOD.GetSchedule80(DNValve),
            PipeScheduleEnum.SCH_80s => DNtoOD.GetSchedule80s(DNValve),
            PipeScheduleEnum.XS      => DNtoOD.GetScheduleXS(DNValve),
            PipeScheduleEnum.SCH_120 => DNtoOD.GetSchedule120(DNValve),
            PipeScheduleEnum.SCH_160 => DNtoOD.GetSchedule160(DNValve),
            PipeScheduleEnum.XXS     => DNtoOD.GetScheduleXXS(DNValve),
            _ => throw new NotImplementedException(),
        };



    }


}
