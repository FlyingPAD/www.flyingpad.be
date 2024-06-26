import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateStyleComponent } from './update-style.component';

describe('UpdateStyleComponent', () => {
  let component: UpdateStyleComponent;
  let fixture: ComponentFixture<UpdateStyleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateStyleComponent]
    });
    fixture = TestBed.createComponent(UpdateStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
