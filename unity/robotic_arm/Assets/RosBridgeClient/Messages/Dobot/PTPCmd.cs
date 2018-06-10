﻿/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Dobot
{
    public class PTPCmd : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "dobot/PTPCmd";
        public uint ptpMode;
        public float x;
        public float y;
        public float z;
        public float r;
        public PTPCmd()
        {
            ptpMode = 1;
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
            r = 0.0f;
        }
    }

}