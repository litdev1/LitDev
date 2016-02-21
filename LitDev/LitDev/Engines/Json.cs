using Box2DX.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace LitDev.Json
{
    [DataContract]
    public class JsonWorld
    {
        [DataMember]
        public JsonVector gravity = new JsonVector(0, 10);

        [DataMember]
        public bool allowSleep = true;

        [DataMember]
        public bool autoClearForces= true;

        [DataMember]
        public int positionIterations = 2;

        [DataMember]
        public int velocityIterations = 6;

        [DataMember]
        public int stepsPerSecond = 40;

        [DataMember]
        public bool warmStarting = false;

        [DataMember]
        public bool continuousPhysics = true;

        [DataMember]
        public bool subStepping = false;

        [DataMember]
        public List<JsonBody> body;

        [DataMember]
        public List<JsonImage> image;

        [DataMember]
        public List<JsonJoint> joint;
    }

    [DataContract]
    public class JsonVector
    {
        [DataMember]
        public float x;

        [DataMember]
        public float y;

        public JsonVector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public JsonVector(Vec2 vec2)
        {
            x = vec2.X;
            y = vec2.Y;
        }

        public Vec2 Get()
        {
            return new Vec2(x, y);
        }
    }

    [DataContract]
    public class JsonVectorArray
    {
        [DataMember]
        public List<float> x;

        [DataMember]
        public List<float> y;

        public JsonVectorArray(List<float> x, List<float> y)
        {
            this.x = x;
            this.y = y;
        }
    }

    [DataContract]
    public class JsonBody
    {
        [DataMember]
        public string name;

        [DataMember]
        public int type;

        [DataMember]
        public float angle = 0;

        [DataMember]
        public float angularDamping = 0;

        [DataMember]
        public float angularVelocity = 0;

        [DataMember]
        public bool awake = true;

        [DataMember]
        public bool bullet = false;

        [DataMember]
        public bool fixedRotation = false;

        [DataMember]
        public float linearDamping = 0;

        [DataMember]
        public JsonVector linearVelocity = new JsonVector(0, 0);

        [DataMember(Name = "massData-mass")]
        public float massData_mass;

        [DataMember(Name = "massData-center")]
        public JsonVector massData_center;

        [DataMember(Name = "massData-I")]
        public float massData_I;

        [DataMember]
        public JsonVector position;

        [DataMember]
        public List<JsonFixture> fixture;

        [DataMember]
        public List<JsonCustomProperties> customProperties;
    }

    [DataContract]
    public class JsonFixture
    {
        [DataMember]
        public string name;

        [DataMember]
        public float density = 1;

        [DataMember(Name = "filter-categoryBits")]
        public int filter_categoryBits = 1;

        [DataMember(Name = "filter-maskBits")]
        public int filter_maskBits = 65535;

        [DataMember(Name = "filter-groupIndex")]
        public int filter_groupIndex;

        [DataMember]
        public float friction;

        [DataMember]
        public float restitution;

        [DataMember]
        public bool sensor;

        [DataMember]
        public JsonCircle circle = null;

        [DataMember]
        public JsonPolygon polygon = null;

        [DataMember]
        public JsonChain chain = null;

        [DataMember]
        public List<JsonCustomProperties> customProperties;
    }

    [DataContract]
    public class JsonImage
    {
        [DataMember]
        public string name;

        [DataMember]
        public float opacity = 1;

        [DataMember]
        public float renderOrder = 0;

        [DataMember]
        public float scale = 1;

        [DataMember]
        public float aspectScale = 1;

        [DataMember]
        public float angle = 0;

        [DataMember]
        public int body = 0;

        [DataMember]
        public JsonVector center = new JsonVector(0, 0);

        [DataMember]
        public JsonVectorArray corners;

        [DataMember]
        public string file;

        [DataMember]
        public int filter;

        [DataMember]
        public bool flip = false;

        [DataMember]
        public int[] colorTint = new int[4] { 255, 255, 255, 255 };

        [DataMember]
        public int[] glDrawElements;

        [DataMember]
        public int[] glTexCoordPointer;

        [DataMember]
        public float[] glVertexPointer;

        [DataMember]
        public List<JsonCustomProperties> customProperties;
    }

    [DataContract]
    public class JsonJoint
    {
        [DataMember]
        public string type;

        [DataMember]
        public string name;

        [DataMember]
        public JsonVector anchorA;

        [DataMember]
        public JsonVector anchorB;

        [DataMember]
        public int bodyA;

        [DataMember]
        public int bodyB;

        [DataMember]
        public bool collideConnected = false;

        [DataMember]
        public bool enableLimit = false;

        [DataMember]
        public bool enableMotor = false;

        [DataMember]
        public float jointSpeed;

        [DataMember]
        public float lowerLimit;

        [DataMember]
        public float maxMotorTorque;

        [DataMember]
        public float motorSpeed;

        [DataMember]
        public float refAngle;

        [DataMember]
        public float upperLimit;

        [DataMember]
        public float dampingRatio = 0;

        [DataMember]
        public float frequency;

        [DataMember]
        public float length;

        [DataMember]
        public JsonVector localAxisA;

        [DataMember]
        public float maxMotorForce;

        [DataMember]
        public float springDampingRatio;

        [DataMember]
        public float springFrequency;

        [DataMember]
        public float maxLength;

        [DataMember]
        public float maxForce;

        [DataMember]
        public float maxTorque;

        [DataMember]
        public float correctionFactor;

        [DataMember]
        public List<JsonCustomProperties> customProperties;
    }

    [DataContract]
    public class JsonCircle
    {
        [DataMember]
        public JsonVector center;

        [DataMember]
        public float radius = 1;

        public JsonCircle(JsonVector center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }

    [DataContract]
    public class JsonPolygon
    {
        [DataMember]
        public JsonVectorArray vertices;

        public JsonPolygon(JsonVectorArray vertices)
        {
            this.vertices = vertices;
        }
    }

    [DataContract]
    public class JsonChain
    {
        [DataMember]
        public JsonVectorArray vertices;

        [DataMember]
        public bool hasNextVertex = false;

        [DataMember]
        public bool hasPrevVertex = false;

        [DataMember]
        public JsonVector nextVertex;

        [DataMember]
        public JsonVector prevVertex;

        public JsonChain(JsonVectorArray vertices)
        {
            this.vertices = vertices;
        }
    }

    [DataContract]
    public class JsonCustomProperties
    {
        [DataMember]
        public string name;

        [DataMember(Name = "float")]
        public float value;

        public JsonCustomProperties(string name, float value)
        {
            this.name = name;
            this.value = value;
        }
    }

    class JsonPhysics
    {
        public PhysicsEngine Engine;

        public JsonPhysics(PhysicsEngine Engine)
        {
            this.Engine = Engine;
        }

        public void Write(string filename)
        {
            JsonWorld world = new JsonWorld();
            world.positionIterations = Engine.positionIterations;
            world.velocityIterations = Engine.velocityIterations;
            world.stepsPerSecond = (int)(1.0f/Engine.timeStep);
            Engine.GetWorld().SetJson(world);

            FileStream stream1 = new FileStream(filename, FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JsonWorld));
            ser.WriteObject(stream1, world);
            stream1.Close();

            string content = File.ReadAllText(filename);
            File.WriteAllText(filename,FormatJson(content));
        }

        public JsonWorld Read(string filename)
        {
            FileStream stream1 = new FileStream(filename, FileMode.Open);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JsonWorld));
            JsonWorld world = (JsonWorld)ser.ReadObject(stream1);
            stream1.Close();

            return world;
        }

        private const string INDENT_STRING = "  ";

        static string FormatJson(string json)
        {
            int indentation = 0;
            int quoteCount = 0;
            var result =
                from ch in json
                let quotes = ch == '"' ? quoteCount++ : quoteCount
                let lineBreak = ch == ',' && quotes % 2 == 0 ? ch + Environment.NewLine + String.Concat(Enumerable.Repeat(INDENT_STRING, indentation)) : null
                let openChar = ch == '{' || ch == '[' ? ch + Environment.NewLine + String.Concat(Enumerable.Repeat(INDENT_STRING, ++indentation)) : ch.ToString()
                let closeChar = ch == '}' || ch == ']' ? Environment.NewLine + String.Concat(Enumerable.Repeat(INDENT_STRING, --indentation)) + ch : ch.ToString()
                select lineBreak == null
                            ? openChar.Length > 1
                                ? openChar
                                : closeChar
                            : lineBreak;

            return string.Concat(result);
        }
    }
}
