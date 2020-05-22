import {post} from "./post";
import {User} from "./User";

export interface Category {
  name:string;
  posts:post[];
  user:User;
}
