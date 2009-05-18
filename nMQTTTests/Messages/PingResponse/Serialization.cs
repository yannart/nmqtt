﻿/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://code.google.com/p/nmqtt
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Nmqtt;

namespace NmqttTests.Messages.PingResponse
{
    /// <summary>
    /// MQTT Message Ping Response Serialization Tests
    /// </summary>
    public class Serialization
    {
        /// <summary>
        /// Tests basic message Serialization
        /// </summary>
        [Fact]
        public void BasicDeserialization()
        {
            // standard byte array of a ping response message.
            var expected = new[]
            {
                (byte)0xD0,
                (byte)0x00,
            };

            MqttPingResponseMessage msg = new MqttPingResponseMessage();
            Console.WriteLine(msg);

            byte[] actual = MessageSerializationHelper.GetMessageBytes(msg);

            Assert.Equal<int>(expected.Length, actual.Length);
            Assert.Equal<byte>(expected[0], actual[0]); // first header byte
            Assert.Equal<byte>(expected[1], actual[1]); // message size byte
        }
    } 
}