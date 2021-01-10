// package: FileTime
// file: filer.proto

var filer_pb = require("./filer_pb");
var grpc = require("@improbable-eng/grpc-web").grpc;

var Filer = (function () {
  function Filer() {}
  Filer.serviceName = "FileTime.Filer";
  return Filer;
}());

Filer.FilerLogin = {
  methodName: "FilerLogin",
  service: Filer,
  requestStream: false,
  responseStream: false,
  requestType: filer_pb.FilerLoginRequest,
  responseType: filer_pb.FilerLoginReply
};

exports.Filer = Filer;

function FilerClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

FilerClient.prototype.filerLogin = function filerLogin(requestMessage, metadata, callback) {
  if (arguments.length === 2) {
    callback = arguments[1];
  }
  var client = grpc.unary(Filer.FilerLogin, {
    request: requestMessage,
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport,
    debug: this.options.debug,
    onEnd: function (response) {
      if (callback) {
        if (response.status !== grpc.Code.OK) {
          var err = new Error(response.statusMessage);
          err.code = response.status;
          err.metadata = response.trailers;
          callback(err, null);
        } else {
          callback(null, response.message);
        }
      }
    }
  });
  return {
    cancel: function () {
      callback = null;
      client.close();
    }
  };
};

exports.FilerClient = FilerClient;

