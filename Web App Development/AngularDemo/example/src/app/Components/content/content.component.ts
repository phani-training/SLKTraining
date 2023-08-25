import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  //members of our component
  value1 : number = 12.0;
  value2 : number = 13.0;
  operand : string = "Add"
  result : number = this.value1 + this.value2;

  onClick = () =>{
    switch (this.operand) {
      case "Add": this.result = this.value1 + this.value2 ; break;
      case "Subtract": this.result = this.value1 - this.value2 ; break;
      case "Multiply": this.result = this.value1 * this.value2 ; break;
      case "Divide": this.result = this.value1 / this.value2 ; break;
      default:
        break;
    }
  }
}
