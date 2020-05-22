import { User } from "./User";

export interface Post {
  title:string;
  bode:string;
  rating:number;
  timeStamp:Date;
  owner:User;
}
