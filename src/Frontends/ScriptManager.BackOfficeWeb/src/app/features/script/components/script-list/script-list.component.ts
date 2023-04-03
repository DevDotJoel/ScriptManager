import { Component, Input } from '@angular/core';
import { ScriptModel } from 'src/app/models/ScriptModel';

@Component({
  selector: 'app-script-list',
  templateUrl: './script-list.component.html',
  styleUrls: ['./script-list.component.css']
})
export class ScriptListComponent {
  displayedColumns: string[] = ['Name', 'Description', 'Total Questions', 'Actions'];
  @Input() scripts:ScriptModel[];
  constructor() { }

  ngOnInit(): void {
  }
}
