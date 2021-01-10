import { Injectable } from '@angular/core';
import { grpc } from "@improbable-eng/grpc-web";
import { Filer } from "src/app/core/proto/generated/filer_pb_service";
import { FilerLoginRequest, FilerLoginReply } from "src/app/core/proto/generated/filer_pb";

@Injectable({
  providedIn: 'root'
})
export class FilerService {


  constructor() { }

  login(model: FilerLoginRequest): any {
    grpc.unary(Filer.FilerLogin, {
      request: model,
      host: "https://localhost:5001/",
      onEnd: res => {
        const { status, message } = res;
        if (status === grpc.Code.OK && message) {
          const result = message.toObject() as FilerLoginReply.AsObject;
          return result.emailaddress;
        }
        else {
          return "";
        }
      }
    });

   
  }

}
