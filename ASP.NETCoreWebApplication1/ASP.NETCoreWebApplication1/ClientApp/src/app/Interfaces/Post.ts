import { User } from "./User";

export interface post {
  title:string;
  body:string;
  rating:number;
  timeStamp:string;
  owner:User;
}
