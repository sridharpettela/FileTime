// package: FileTime
// file: filer.proto

import * as filer_pb from "./filer_pb";
import {grpc} from "@improbable-eng/grpc-web";

type FilerFilerLogin = {
  readonly methodName: string;
  readonly service: typeof Filer;
  readonly requestStream: false;
  readonly responseStream: false;
  readonly requestType: typeof filer_pb.FilerLoginRequest;
  readonly responseType: typeof filer_pb.FilerLoginReply;
};

export class Filer {
  static readonly serviceName: string;
  static readonly FilerLogin: FilerFilerLogin;
}

export type ServiceError = { message: string, code: number; metadata: grpc.Metadata }
export type Status = { details: string, code: number; metadata: grpc.Metadata }

interface UnaryResponse {
  cancel(): void;
}
interface ResponseStream<T> {
  cancel(): void;
  on(type: 'data', handler: (message: T) => void): ResponseStream<T>;
  on(type: 'end', handler: (status?: Status) => void): ResponseStream<T>;
  on(type: 'status', handler: (status: Status) => void): ResponseStream<T>;
}
interface RequestStream<T> {
  write(message: T): RequestStream<T>;
  end(): void;
  cancel(): void;
  on(type: 'end', handler: (status?: Status) => void): RequestStream<T>;
  on(type: 'status', handler: (status: Status) => void): RequestStream<T>;
}
interface BidirectionalStream<ReqT, ResT> {
  write(message: ReqT): BidirectionalStream<ReqT, ResT>;
  end(): void;
  cancel(): void;
  on(type: 'data', handler: (message: ResT) => void): BidirectionalStream<ReqT, ResT>;
  on(type: 'end', handler: (status?: Status) => void): BidirectionalStream<ReqT, ResT>;
  on(type: 'status', handler: (status: Status) => void): BidirectionalStream<ReqT, ResT>;
}

export class FilerClient {
  readonly serviceHost: string;

  constructor(serviceHost: string, options?: grpc.RpcOptions);
  filerLogin(
    requestMessage: filer_pb.FilerLoginRequest,
    metadata: grpc.Metadata,
    callback: (error: ServiceError|null, responseMessage: filer_pb.FilerLoginReply|null) => void
  ): UnaryResponse;
  filerLogin(
    requestMessage: filer_pb.FilerLoginRequest,
    callback: (error: ServiceError|null, responseMessage: filer_pb.FilerLoginReply|null) => void
  ): UnaryResponse;
}

