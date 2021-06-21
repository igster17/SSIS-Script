/* THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT!
*  Microsoft SQL Server Integration Services buffer wrappers
*  This module defines classes for accessing data flow buffers
*  THIS IS AUTO-GENERATED CODE THAT WILL BE OVERWRITTEN! DO NOT EDIT! */



using System;
using System.Data;
using Microsoft.SqlServer.Dts.Pipeline;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;

public class Output0Buffer: ScriptBuffer

{
    public Output0Buffer(PipelineBuffer Buffer, int[] BufferColumnIndexes, OutputNameMap OutputMap)
        : base(Buffer, BufferColumnIndexes, OutputMap)
    {
    }

    public String dwDataExportID
    {
        set
        {
            this[0] = value;
        }
    }
    public bool dwDataExportID_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(0);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String requestCreatorName
    {
        set
        {
            this[1] = value;
        }
    }
    public bool requestCreatorName_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(1);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String requestCreatedTimeLocal
    {
        set
        {
            this[2] = value;
        }
    }
    public bool requestCreatedTimeLocal_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(2);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String requestAirlinePrimary
    {
        set
        {
            this[3] = value;
        }
    }
    public bool requestAirlinePrimary_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(3);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String paxName
    {
        set
        {
            this[4] = value;
        }
    }
    public bool paxName_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(4);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String adhocPlanned
    {
        set
        {
            this[5] = value;
        }
    }
    public bool adhocPlanned_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(5);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String currentSSR
    {
        set
        {
            this[6] = value;
        }
    }
    public bool currentSSR_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(6);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String arrivalFlightScheduledGateArrivalTimeLocal
    {
        set
        {
            this[7] = value;
        }
    }
    public bool arrivalFlightScheduledGateArrivalTimeLocal_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(7);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String departureFlightScheduledGateDepartureTimeLocal
    {
        set
        {
            this[8] = value;
        }
    }
    public bool departureFlightScheduledGateDepartureTimeLocal_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(8);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String scheduledPickupTerminal
    {
        set
        {
            this[9] = value;
        }
    }
    public bool scheduledPickupTerminal_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(9);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String scheduledPickupTime
    {
        set
        {
            this[10] = value;
        }
    }
    public bool scheduledPickupTime_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(10);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String finalCloseTimeLocal
    {
        set
        {
            this[11] = value;
        }
    }
    public bool finalCloseTimeLocal_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(11);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String requestStatusType
    {
        set
        {
            this[12] = value;
        }
    }
    public bool requestStatusType_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(12);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    public String disregardCode
    {
        set
        {
            this[13] = value;
        }
    }
    public bool disregardCode_IsNull
    {
        set
        {
            if (value)
            {
                SetNull(13);
            }
            else
            {
                throw new InvalidOperationException("IsNull property cannot be set to False. Assign a value to the column instead.");
            }
        }
    }

    new public void AddRow()
    {
        base.AddRow();
    }

    new public void SetEndOfRowset()
    {
        base.SetEndOfRowset();
    }

    new public bool EndOfRowset()
    {
        return base.EndOfRowset();
    }

}
