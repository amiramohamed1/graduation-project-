import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EnteryComponent } from './entery.component';

describe('EnteryComponent', () => {
  let component: EnteryComponent;
  let fixture: ComponentFixture<EnteryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EnteryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EnteryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
