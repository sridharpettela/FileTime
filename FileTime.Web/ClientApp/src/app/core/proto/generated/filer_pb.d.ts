// package: FileTime
// file: filer.proto

import * as jspb from "google-protobuf";

export class FilerLoginRequest extends jspb.Message {
  getEmailaddress(): string;
  setEmailaddress(value: string): void;

  getPassword(): string;
  setPassword(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): FilerLoginRequest.AsObject;
  static toObject(includeInstance: boolean, msg: FilerLoginRequest): FilerLoginRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: FilerLoginRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): FilerLoginRequest;
  static deserializeBinaryFromReader(message: FilerLoginRequest, reader: jspb.BinaryReader): FilerLoginRequest;
}

export namespace FilerLoginRequest {
  export type AsObject = {
    emailaddress: string,
    password: string,
  }
}

export class FilerLoginReply extends jspb.Message {
  getEmailaddress(): string;
  setEmailaddress(value: string): void;

  getPassword(): string;
  setPassword(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): FilerLoginReply.AsObject;
  static toObject(includeInstance: boolean, msg: FilerLoginReply): FilerLoginReply.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: FilerLoginReply, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): FilerLoginReply;
  static deserializeBinaryFromReader(message: FilerLoginReply, reader: jspb.BinaryReader): FilerLoginReply;
}

export namespace FilerLoginReply {
  export type AsObject = {
    emailaddress: string,
    password: string,
  }
}

