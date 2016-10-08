using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VizceralAPI.Models;
using Nest;

namespace VizceralAPI.Services
{
    public class TrafficAggregator : ITrafficAggregator
    {
        private Lazy<ElasticClient> _elasticClient;

        public TrafficAggregator(string address) {

          _elasticClient = new Lazy<ElasticClient>(() => {
                return InitElasticClient(address);
            });

        }

        protected ElasticClient elastic => _elasticClient.Value;

        static ElasticClient InitElasticClient(string address) 
        {
            var node = new Uri(address);
            var settings = new ConnectionSettings(node);
            settings.DefaultIndex("traffic");
            settings.DisableDirectStreaming(); //DEBUGGING
            return new ElasticClient(settings);
        }

        public async Task<Traffic> Latest(int minutes)
        {
            return await populateTraffic(minutes);
        }

        private async Task<Traffic> populateTraffic(int minutes)
        {
            var traffic = new Traffic();
            traffic.nodes= await getNodes();
            traffic.connections = await getconnections();

            traffic.serverUpdateTime=DateTime.Now.Ticks;
            return traffic;
        }

        private Task<IList<Node>> getNodes()
        {
            throw new NotImplementedException();
        }

        private Task<IList<Connection>> getconnections()
        {
            throw new NotImplementedException();
        }
    }
}