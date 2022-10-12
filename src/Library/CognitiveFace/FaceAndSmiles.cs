using System;
namespace RideShare;
public class FaceAndSmiles{
    public static bool FoundFace(CognitiveFace cog, bool conductor)
            {
                if(conductor){
                    return cog.SmileFound && cog.FaceFound;
                }
                else
                {
                    return cog.FaceFound;
                }
            }
}